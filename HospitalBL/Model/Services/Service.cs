using HospitalBL.Model.Repositories;
using HospitalBL.Model.Services.Interfaces;
using NLog;
using System;
using System.ComponentModel;
using System.Linq;

namespace HospitalBL.Model.Services
{
    class Service<T> : IService<T> where T : class
    {
        private Logger logger = LogManager.GetCurrentClassLogger();

        private readonly IRepository<T> repository;
        protected int NextId;
        public Service(IRepository<T> repository)
        {            
            if (repository is null) throw new ArgumentNullException($"Ошибка инициализации сервиса {this.GetType().Name} ");
            this.repository = repository;
            if (repository.GetAll().Count > 0)
            {
                T elem = repository.GetAll().Last();
                PropertyDescriptor property = TypeDescriptor.GetProperties(elem)["Id"];
                if (!(property is null)) NextId = (int)property.GetValue(elem);
            }
            else NextId = 0;
        }

        public virtual bool SupportEditing => false;

        public virtual bool SupportValidation => false;

        public virtual void AddElement(T elem)
        {
            if (elem is null) throw new ArgumentException("Попытка добавления пустого элемента");
            repository.AddElem(elem);
            Save();
        }

        public virtual void EditElement(int id, T newCustomer)
        {
            if (SupportEditing)
                throw new NotImplementedException();
        }

        public virtual T FindById(int id)
        {
            string filter = GetElement().Filter;
            RemoveFilter();
            int index = GetElement().Find("Id", id);
            if (index < 0) return null;
            T element = GetElement()[index];
            SetFilter(filter);
            return element;
        }

        public virtual BindingListView<T> GetElement()
        {
            return repository.GetAll();
        }

        public virtual void Load()
        {
            logger.Info($"Загрузка данных данных {typeof(T).Name}...");
            repository.Load();            
        }

        public virtual void RemoveElement(int id)
        {
            T elem = FindById(id);
            if (elem is null) throw new ArgumentException("Выбранного элемента нет в базе");

            repository.RemoveElem(elem);
            Save();
        }

        public virtual void Save()
        {
            logger.Info($"Сохранение данных данных {typeof(T).Name}...");
            repository.Save();
            logger.Info("Данные сохранены");
        }

        public virtual void ValidateElement(T customer)
        {
            if (SupportValidation)
                throw new NotImplementedException();
        }

        public virtual void RemoveFilter()
        {
            GetElement().RemoveFilter();
        }

        public virtual void SetFilter(string filter)
        {
            RemoveFilter();
            GetElement().Filter = filter;
        }
    }
}
