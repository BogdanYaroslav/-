using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Diagnosis;

namespace HospitalBL.Model.Repositories
{
    class DiseaseRepository : Repository<Disease>
    {
        public DiseaseRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
}
