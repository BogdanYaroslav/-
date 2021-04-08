using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Person;

namespace HospitalBL.Model.Repositories
{
    class PatientRepository : Repository<Patient>
    {
        public PatientRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
}
