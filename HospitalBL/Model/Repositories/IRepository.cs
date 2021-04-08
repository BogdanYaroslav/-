using System.Collections.Generic;

namespace HospitalBL.Model.Repositories
{
    interface IRepository<T>
    {
        BindingListView<T> GetAll();
        void AddElem(T element);
        void RemoveElem(T element);
        void Save();
        IEnumerable<T> Load();
    }
}