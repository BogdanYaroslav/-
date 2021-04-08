using HospitalBL.Model.Entities.Diagnosis;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface ITreatmentService: IService<Treatment>
    {
        string FilterByName(string name, bool setFilter = false);
        string FilterByDisease(int idDisease, bool setFilter = false);
        string FilterByDisease(int idDisease, string name, bool setFilter = false);
    }
}
