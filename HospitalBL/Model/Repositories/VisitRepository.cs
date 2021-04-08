using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Visit;

namespace HospitalBL.Model.Repositories
{
    class VisitRepository : Repository<Visit>
    {
        public VisitRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
    
}
