namespace HospitalBL.Model.Entities
{
    public interface IEntity
    {
        int Id { get; set; }

        void Edit(object obj);

    }
}