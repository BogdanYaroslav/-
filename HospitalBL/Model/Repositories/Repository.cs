using HospitalBL.MainServices.Interfaces;
using System.Collections.Generic;

namespace HospitalBL.Model.Repositories
{
    class Repository<T> : IRepository<T> where T:class
    {
        private readonly BindingListView<T> elements;
        private readonly ISerialization serializationService;

        public Repository(ISerialization serializationService)
        {
            this.serializationService = serializationService;
            elements = new BindingListView<T>(Load());
            if (elements is null) elements = new BindingListView<T>();
        }

        public virtual BindingListView<T> GetAll()
        {
            return elements;
        }

        public virtual void AddElem(T element)
        {
            if (element != null)
                elements.Add(element);
        }

        public virtual void RemoveElem(T element)
        {            
            if (element != null)
                elements.Remove(element);
        }

        public virtual void Save()
        {           
            serializationService.SerializeCollection(elements.OriginalList);
        }

        public virtual IEnumerable<T> Load()
        {
            return serializationService.DeserializeCollection<T>();
        }
    }
}
