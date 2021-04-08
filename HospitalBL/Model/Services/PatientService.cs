using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.Linq;

namespace HospitalBL.Model.Services
{
    class PatientService :Service<Patient>, IPatientService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public override bool SupportEditing => true;
        public override bool SupportValidation => true;

        public PatientService(IRepository<Patient> repository) : base(repository)
        { }


        public override void AddElement(Patient patient)
        {
            logger.Info($"Выполняется добаление пациента {patient}...");

            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор)
                throw new Exception("Добавлять новых пациентов может только регистратор");

            ValidateElement(patient);
            patient.Id = ++NextId;

            base.AddElement(patient);
            logger.Info($"Пациент {patient} добавлен");
        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления пациента...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор)  
                throw new Exception("Удалять пациентов может только регистратор");

            base.RemoveElement(id);
            logger.Info($"Пациент удален");
        }

        public override void EditElement(int id, Patient newPatient)
        {
            logger.Info($"Выполняется редактирование пациента...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор) 
                throw new FieldAccessException("Редактировать пациентов может только продавец");

            Patient patient = FindById(id);
            if (patient is null) throw new ArgumentNullException("Выбранного пациента нет в базе");

            ValidateElement(newPatient);
            logger.Info($"Редактирование пациента {patient}...");
            patient.Edit(newPatient);
            logger.Info("Редактирование завершено");
            Save();
        }

        public override void ValidateElement(Patient patient)
        {
            logger.Info($"Выполняется валидация данных пациента {patient}...");
            if(patient is null) throw new ArgumentException("Пациент не создан");
            if (string.IsNullOrWhiteSpace(patient.Name)) throw new ArgumentException("Имя не может быть пустым");
            if (string.IsNullOrWhiteSpace(patient.Surname)) throw new ArgumentException("Фамилия не может быть пустой");
            if (string.IsNullOrWhiteSpace(patient.Phone)) throw new ArgumentException("Обязательно должен быть номер телефона");


            if (patient.Name.Length < 2 || patient.Name.Length > 100 || !patient.Name.All(c => char.IsLetter(c))) throw new ArgumentException("Имя должно быть от 2 до 100 символов и содержать только буквы");
            if (patient.Surname.Length < 3 || patient.Surname.Length > 100 || !patient.Surname.All(c => char.IsLetter(c))) throw new ArgumentException("Фамилия должно быть от 2 до 100 символов и содержать только буквы");
            if (patient.Phone.Length != 12 || !patient.Phone.All(c => char.IsDigit(c))) throw new ArgumentException("Номер должен содержать 12 цифр");
            if (patient.Age < 18 || patient.Age > 70) throw new ArgumentException("Неподходящий возраст");

            Patient patientInBase = GetElement().OriginalList.SingleOrDefault(e => e.FullName.Equals(patient.FullName) && e.Phone.Equals(patient.Phone));
            if (!(patientInBase is null)) throw new ArgumentException("Такой пациент уже есть");

            logger.Info("Валидация завершена");
        }

        public string FilterByName(string name, bool setFilter = false)
        {
            string filter = string.Empty;
            BindingListView<Patient> list = new BindingListView<Patient>(GetElement().OriginalList);

            filter = $"[FullName] = '{name}'";
            list.Filter = filter;
            if (list.Count == 0) filter = $"[Name] = '{name}'";
            list.Filter = filter;
            if (list.Count == 0) filter = $"[Surname] = '{name}'";

            if (setFilter) SetFilter(filter);
            return filter;
        }
    }
}
