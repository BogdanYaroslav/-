using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Diagnosis;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

namespace HospitalBL.Model.Services
{
    class DiagnosisService : Service<Diagnosis>, IDiagnosisService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public override bool SupportEditing => true;
        public override bool SupportValidation => true;
        private string hospitalCertificate;

        public DiagnosisService(IRepository<Diagnosis> repository) : base(repository)
        { }

        public override void AddElement(Diagnosis diagnosis)
        {
            logger.Info($"Выполняется добаление диагноза {diagnosis}...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Добавлять диагноз может только врач");

            ValidateElement(diagnosis);
            diagnosis.Id = ++NextId;            

            base.AddElement(diagnosis);
            logger.Info($"Диагноз {diagnosis} добавлен");
        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления диагноза...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Удалять диагноз может только врач");

            base.RemoveElement(id);
            logger.Info($"Диагноз удален");
        }

        public override void EditElement(int id, Diagnosis newDiagnosis)
        {
            logger.Info($"Выполняется редактирование диагноза...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new FieldAccessException("Редактировать диагноз может только врач");

            Diagnosis diagnosis = FindById(id);
            if (diagnosis is null) throw new ArgumentNullException("Выбранного диагноза нет в базе");

            ValidateElement(newDiagnosis);
            logger.Info($"Редактирование диагноза {diagnosis}...");
            diagnosis.Edit(newDiagnosis);
            logger.Info("Редактирование завершено");
            Save();
        }


        public override void ValidateElement(Diagnosis diagnosis)
        {
            logger.Info($"Выполняется валидация данных товара {diagnosis}...");
            if (diagnosis is null) throw new ArgumentException("Диагноз не создан");
            
            if (diagnosis.PatientID <= 0) throw new ArgumentException("У диагноза должен быть указан пациент");
            if (diagnosis.DoctorID <= 0) throw new ArgumentException("У диагноза должен быть указан врач");
            if (diagnosis.DiseaseID <= 0) throw new ArgumentException("У диагноза должно быть указано заболевание");
            if (diagnosis.TreatmentID <= 0) throw new ArgumentException("У диагноза должно быть указано лечение");
            if (diagnosis.Date.Date != DateTime.Today) throw new ArgumentException("Диагноз не может быть поставлен левым числом");

            Diagnosis diagnosisInBase = HospitalManager.GetInstance().DiagnosisService.GetElement().SingleOrDefault(d => d.Equals(diagnosis));
            if (!(diagnosisInBase is null)) throw new ArgumentException("Такой диагноз уже есть");
            logger.Info("Валидация завершена");
        }

        public string FilterByPatient(int idPatient, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[PatientID] = '{idPatient}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByDoctor(int idDoctor, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[DoctorID] = '{idDoctor}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByDisease(int idDisease, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[DiseaseID] = '{idDisease}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByTreatment(int idTreatment, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[TreatmentID] = '{idTreatment}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByService(int idDoctor = 0, int idPatient = 0, int idDisease = 0, int idTreatment = 0, bool setFilter = false)
        {
            string filter = string.Empty;

            if (idDoctor > 0) filter = FilterByDoctor(idDoctor);

            if (idPatient > 0)
            {
                if (filter.Equals(string.Empty))
                {
                    filter = FilterByPatient(idPatient);
                }
                else
                {
                    filter += $" AND {FilterByPatient(idPatient)}";
                }
            }
            if (idDisease > 0)
            {
                if (filter.Equals(string.Empty))
                {
                    filter = FilterByDisease(idDisease);
                }
                else
                {
                    filter += $" AND {FilterByDisease(idDisease)}";
                }
            }
            if (idTreatment> 0)
            {
                if (filter.Equals(string.Empty))
                {
                    filter = FilterByTreatment(idTreatment);
                }
                else
                {
                    filter += $" AND {FilterByTreatment(idTreatment)}";
                }
            }

            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByParams(TimeBasedFilteringType visitTypeSearch, DateTime dateParam, int idDoctor = 0, int idPatient = 0, int idDisease = 0, int idTreatment = 0, bool setFilter = false)
        {
            string filter = string.Empty;

            if (filter.Equals(string.Empty)) filter = FilterByService(idDoctor, idPatient, idDisease, idTreatment);
            else filter += $" AND '{FilterByService(idDoctor, idPatient, idDisease, idTreatment)}'";

            if (visitTypeSearch == TimeBasedFilteringType.Год)
            {
                if (filter.Equals(string.Empty)) filter = $"[Year] = '{dateParam.Year}'";
                else filter += $" AND [Year] = '{dateParam.Year}'";
            }
            else if (visitTypeSearch == TimeBasedFilteringType.Месяц)
            {
                if (filter.Equals(string.Empty)) filter = $"[Mounth] = '{dateParam.Month}' AND [Year] = '{dateParam.Year}'";
                else filter += $" AND [Mounth] = '{dateParam.Month}' AND [Year] = '{dateParam.Year}'";
            }
            else if (visitTypeSearch == TimeBasedFilteringType.День)
            {
                if (filter.Equals(string.Empty)) filter = $"[Mounth] = '{dateParam.Month}' AND [Year] = '{dateParam.Year}' AND [Day] = '{dateParam.Day}'";
                else filter += $" AND [Mounth] = '{dateParam.Month}' AND [Year] = '{dateParam.Year}' AND [Day] = '{dateParam.Day}'";
            }

            if (setFilter) SetFilter(filter);

            return filter;
        }

        public Employee GetDoctor(int id)
        {
            return HospitalManager.GetInstance().EmployeeService.GetElement().OriginalList.SingleOrDefault(e => e.Id == id);
        }

        public Patient GetPatient(int id)
        {
            return HospitalManager.GetInstance().PatientService.GetElement().OriginalList.SingleOrDefault(p => p.Id == id);
        }

        public Disease GetDisease(int id)
        {
            return HospitalManager.GetInstance().DiseaseService.GetElement().OriginalList.SingleOrDefault(d => d.Id == id);
        }

        public Treatment GetTreatment(int id)
        {
            return HospitalManager.GetInstance().TreatmentService.GetElement().OriginalList.SingleOrDefault(t => t.Id == id);
        }

        public void PrintHospitalCertificate(int idDiagnosis)
        {
            PrintDocument PrintDocument = new PrintDocument();
            PrintDocument.PrintPage += printDocument_PrintPage;

            Diagnosis diagnosis = FindById(idDiagnosis);
            Employee doctor = GetDoctor(diagnosis.DoctorID);
            Patient patient = GetPatient(diagnosis.PatientID);
            Disease disease = GetDisease(diagnosis.DiseaseID);
            Treatment treatment = GetTreatment(diagnosis.TreatmentID);

            hospitalCertificate = $"\t\t\t\tСправка №{diagnosis.Id}" +
                $"\nИмя пациента: {patient.FullName}" +
                $"\nПол пациента: {patient.Gender}" +
                $"\nДата рождения пациента: {patient.Birthday.ToLongDateString()}" +
                $"\nВозраст пациента: {patient.Age}" +
                $"\nВыдано врачем: {doctor.FullName}" +
                $"\nПоставлен диагноз: {disease.Name}" +
                $"\nНазначенно лечение: {treatment.Name}" +
                $"\nОписание лечения: {treatment.Description}" +
                $"\nДата уставновления диагноза: {diagnosis.Date.ToLongDateString()}" +
                $"\nДата печати и выдачи справки: {DateTime.Today.ToLongDateString()}";

            PrintDocument.Print();
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(hospitalCertificate, new Font("Times New Roman", 14), Brushes.Black, 0, 0);
        }
    }
}
