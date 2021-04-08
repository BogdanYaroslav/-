using HospitalBL.MainServices.Interfaces;
using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Services.Interfaces;
using System;
using System.Linq;

namespace HospitalBL.MainServices
{
    class AuthorizationService : IAuthorizationService<Employee>
    {
        private readonly IEmployeeService employeeService;
        public AuthorizationService(IEmployeeService employeeService)
        {
            if (employeeService is null) throw new ArgumentNullException("Ошибка инициализации сервиса авторизации");
            this.employeeService = employeeService;
        }
            
        public Employee Login(string login, string password, UserRole role)
        {
            return employeeService.GetElement().OriginalList.SingleOrDefault(e => e.Profile.Login.Equals(login) && e.Profile.Password.Equals(password) && e.Role.Equals(role));
        }
    }
}
