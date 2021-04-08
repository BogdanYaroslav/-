using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Diagnosis;

namespace HospitalBL.Model.Repositories
{
    class TreatmentRepository:Repository<Treatment>
    {
        public TreatmentRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
}
