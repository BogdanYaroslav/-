using HospitalBL.Model.Entities.Diagnosis;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface IDiseaseService : IService<Disease>
    {
        string FilterByName(string name, bool setFilter = false);
    }
}