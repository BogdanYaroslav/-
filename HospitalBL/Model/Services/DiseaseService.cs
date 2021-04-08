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
    class DiseaseService : Service<Disease>, IDiseaseService
    {
        private Logger logger = LogManager.GetCurrentClassLogger();
        public override bool SupportEditing => true;
        public override bool SupportValidation => true;
        public DiseaseService(IRepository<Disease> repository):base(repository)
        { }

        public override void AddElement(Disease disease)
        {
            logger.Info($"Выполняется добаление заболевания {disease}...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Добавлять заболевания может только врач");

            ValidateElement(disease);
            disease.Id = ++NextId;

            

            base.AddElement(disease);
            logger.Info($"Заболевание {disease} добавлена");
        }

        public override void RemoveElement(int id)
        {
            logger.Info($"Выполняется удаления заболевания...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new Exception("Удалять заболевания может только врач");

            base.RemoveElement(id);
            logger.Info($"Заболевание удалено");
        }

        public override void EditElement(int id, Disease newDisease)
        {
            logger.Info($"Выполняется редактирование  заболевания...");
            if (HospitalManager.GetRoleCurrentEmployee() != UserRole.Врач)
                throw new FieldAccessException("Редактировать заболевания может только врач");

            Disease disease = FindById(id);
            if (disease is null) throw new ArgumentNullException("Выбранного заболевания нет в базе");

            ValidateElement(newDisease);
            logger.Info($"Редактирование заболевания {disease}...");
            disease.Edit(newDisease);
            logger.Info("Редактирование завершено");
            Save();
        }

        public override void ValidateElement(Disease disease)
        {
            logger.Info($"Выполняется валидация данных заболевания {disease}...");
            if (disease is null) throw new ArgumentException("Заболевание не создано");
            if (string.IsNullOrWhiteSpace(disease.Name)) throw new ArgumentException("Название не может быть пустым");
            if (disease.Description is null) throw new ArgumentException("Описание не может быть null");

            if (disease.Name.Length < 2 || disease.Name.Length > 100) throw new ArgumentException("Название должно быть от 2 до 100 символов");

            Disease diseaseInBase = GetElement().OriginalList.SingleOrDefault(e => e.Name.Equals(disease.Name));
            if (!(diseaseInBase is null)) throw new ArgumentException("Такое заболевание уже есть");

            logger.Info("Валидация завершена");
        }

        public string FilterByName(string name, bool setFilter = false)
        {
            string filter = string.Empty;
            filter = $"[Name] = '{name}'";

            if (setFilter) SetFilter(filter);
            return filter;
        }
    }
}
