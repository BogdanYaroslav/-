using HospitalBL.Model.Entities;

namespace HospitalBL.MainServices.Interfaces
{
    interface IAuthorizationService<T> where T : class
    {        
        T Login(string login, string password, UserRole role);
    }
}
