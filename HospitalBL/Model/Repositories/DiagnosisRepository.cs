using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Diagnosis;

namespace HospitalBL.Model.Repositories
{
    class DiagnosisRepository : Repository<Diagnosis>
    {
        public DiagnosisRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
}
