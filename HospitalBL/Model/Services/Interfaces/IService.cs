namespace HospitalBL.Model.Services.Interfaces
{
    public interface IService<T> where T:class
    {
        bool SupportEditing { get; }
        bool SupportValidation { get; }
        void AddElement(T element);
        void EditElement(int id, T newElement);
        T FindById(int id);
        BindingListView<T> GetElement();
        void Load();
        void RemoveElement(int id);
        void Save();
        void ValidateElement(T element);
        void RemoveFilter();
        void SetFilter(string filter);

    }
}
