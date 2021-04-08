using HospitalBL.Model.Entities.Person;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface IPatientService: IService<Patient>
    {
        string FilterByName(string name, bool setFilter = false);
    }
}