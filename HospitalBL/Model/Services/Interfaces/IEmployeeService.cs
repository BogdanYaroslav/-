using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using System;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface IEmployeeService : IService<Employee>
    {
        string FilterByRole(UserRole userRole, bool setFilter = false);
        string FilterByName(string name, bool setFilter = false);
        string FilterByName(UserRole userRole, string name, bool setFilter = false);
        Tuple<bool, bool> AccessViewAndEditProfile(Employee employee);

    }
}
