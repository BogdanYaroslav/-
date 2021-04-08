using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Person;
using HospitalBL.Model.Entities.Visit;
using System;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface IVisitService: IService<Visit>
    {
        Employee GetDoctore(int id);
        Patient GetPatient(int id);
        string FilterByDoctor(int idDoctor, bool setFilter = false);
        string FilterByPatient(int idPatient, bool setFilter = false);
        string FilterByService(int idDoctor = 0, int idPatient = 0, bool setFilter = false);
        string FilterByParams(TimeBasedFilteringType visitTypeSearch, DateTime dateParam, int idDoctor = 0, int idPatient = 0, bool setFilter = false);
    }
}
