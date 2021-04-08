using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Diagnosis;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.Linq;

namespace HospitalBL.Model.Services
{
    class TreatmentService: Service<Treatment>, ITreatmentService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public override bool SupportEditing => true;
        public override bool SupportValidation => true;

        public TreatmentService(IRepository<Treatment> repository) : base(repository)
        { }

        public override void AddElement(Treatment treatment)
        {
            logger.Info($"Выполняется добаление лечения {treatment}...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Добавлять лечение может только врач");

            ValidateElement(treatment);
            treatment.Id = ++NextId;

            base.AddElement(treatment);
            logger.Info($"лечение {treatment} добавлено");
        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления лечения...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Удалять лечение может только врач");

            base.RemoveElement(id);
            logger.Info($"Лечение удалено");
        }

        public override void EditElement(int id, Treatment newTreatment)
        {
            logger.Info($"Выполняется редактирование  лечения...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new FieldAccessException("Редактировать лечение может только врач");

            Treatment treatment = FindById(id);
            if (treatment is null) throw new ArgumentNullException("Выбранного лечения нет в базе");

            ValidateElement(newTreatment);
            logger.Info($"Редактирование лечения {treatment}...");
            treatment.Edit(newTreatment);
            logger.Info("Редактирование завершено");
            Save();
        }

        public override void ValidateElement(Treatment treatment)
        {
            logger.Info($"Выполняется валидация данных лечения {treatment}...");
            if (treatment is null) throw new ArgumentException("Лечение не создано");
            if (string.IsNullOrWhiteSpace(treatment.Name)) throw new ArgumentException("Название не может быть пустым");
            if (treatment.Description is null) throw new ArgumentException("Описание не может быть null");

            if (treatment.Name.Length < 2 || treatment.Name.Length > 100) throw new ArgumentException("Название должно быть от 2 до 100 символов");

            Treatment treatmentInBase = GetElement().OriginalList.SingleOrDefault(e => e.Name.Equals(treatment.Name));
            if (!(treatmentInBase is null)) throw new ArgumentException("Такое лечение уже есть");

            logger.Info("Валидация завершена");
        }

        public string FilterByName(string name, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[Name] = '{name}'";

            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByDisease(int idDisease, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[Disease] = '{idDisease}'";

            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByDisease(int idDisease, string name, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = FilterByDisease(idDisease);

            if (filter.Equals(string.Empty)) filter = FilterByName(name);
            else filter += $" AND {FilterByName(name)}";

            if (setFilter) SetFilter(filter);
            return filter;

        }
    }
}
