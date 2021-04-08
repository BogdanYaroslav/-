using HospitalBL.MainServices;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Entities.Visit;
using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.Linq;

namespace HospitalBL.Model.Services
{
    class VisitService : Service<Visit>, IVisitService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        public override bool SupportEditing => true;
        public override bool SupportValidation => true;

        public VisitService(IRepository<Visit> repository) : base(repository)
        { }

        public override void AddElement(Visit visit)
        {
            logger.Info($"Выполняется добаление визита {visit}...");

            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор)
                throw new Exception("Добавлять новые визиты может только регистратор");

            ValidateElement(visit);
            visit.Id = ++NextId;
            base.AddElement(visit);
            logger.Info($"Визит {visit} добавлен");

        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления визита...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор)
                throw new Exception("Удалять визиты может только регистратор");

            base.RemoveElement(id);
            logger.Info($"Визит удален");
        }

        public override void EditElement(int id, Visit newVisit)
        {
            logger.Info($"Выполняется редактирование визита...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Регистратор)
                throw new FieldAccessException("Редактировать визиты может только регистратор");

            Visit visit = FindById(id);
            if (visit is null) throw new ArgumentNullException("Выбранного визита нет в базе");

            ValidateElement(newVisit);
            logger.Info($"Редактирование визита {visit}...");
            visit.Edit(newVisit);
            logger.Info("Редактирование завершено");
            Save();
        }

        public override void ValidateElement(Visit visit)
        {
            logger.Info($"Выполняется валидация данных визита {visit}...");
            if (visit is null) throw new ArgumentException("Визит не создан");
            if (visit.Date < DateTime.Today) throw new ArgumentException("Попытка создать заказ в прошлом времени");
            if(visit.Time < DateTime.Now.TimeOfDay) throw new ArgumentException("Попытка создать заказ в прошлом времени");
            if (visit.Patient <= 0) throw new ArgumentException("Отсутвие пациента");
            if (visit.Doctor <= 0) throw new ArgumentException("Отсутвие врача");
            logger.Info("Валидация завершена");
        }        

        #region Filtering
        public string FilterByParams(TimeBasedFilteringType visitTypeSearch, DateTime dateParam,  int idDoctor = 0, int idPatient = 0, bool setFilter=false)
        {
            string filter = string.Empty;

            if (filter.Equals(string.Empty)) filter = FilterByService(idDoctor, idPatient);
            else filter += $" AND '{FilterByService(idDoctor, idPatient)}'";

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

        public string FilterByDoctor(int idDoctor, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[Doctor] = '{idDoctor}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByPatient(int idPatient, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[Patient] = '{idPatient}'";
            if (setFilter) SetFilter(filter);
            return filter;
        }

        public string FilterByService(int idDoctor = 0, int idPatient = 0, bool setFilter = false)
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

            if (setFilter) SetFilter(filter);
            return filter;
        }
        #endregion

        public Employee GetDoctore(int id)
        {
            return HospitalManager.GetInstance().EmployeeService.GetElement().OriginalList.SingleOrDefault(e => e.Id == id);
        }

        public Patient GetPatient(int id)
        {
            return HospitalManager.GetInstance().PatientService.GetElement().OriginalList.SingleOrDefault(p => p.Id == id);
        }



      
    }
}
