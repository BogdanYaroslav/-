using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities.Person;

namespace HospitalBL.Model.Repositories
{
    class EmployeeRepository : Repository<Employee>
    {
        public EmployeeRepository(ISerialization serializationService) : base(serializationService)
        { }
    }
}
