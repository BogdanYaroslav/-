using HospitalBL.Model.Entities;
using HospitalBL.Model.Entities.Diagnosis;
using HospitalBL.Model.Entities.Person;
using System;

namespace HospitalBL.Model.Services.Interfaces
{
    public interface IDiagnosisService : IService<Diagnosis>
    {        
        void PrintHospitalCertificate(int idDiagnosis);
        Employee GetDoctor(int id);
        Patient GetPatient(int id);
        Disease GetDisease(int id);
        Treatment GetTreatment(int id);
        string FilterByDoctor(int idDoctor, bool setFilter = false);
        string FilterByPatient(int idPatient, bool setFilter = false);
        string FilterByDisease(int idDisease, bool setFilter = false);
        string FilterByTreatment(int idTreatment, bool setFilter = false);
        string FilterByService(int idDoctor = 0, int idPatient = 0, int idDisease = 0, int idTreatment = 0, bool setFilter = false);
        string FilterByParams(TimeBasedFilteringType visitTypeSearch, DateTime dateParam, int idDoctor = 0, int idPatient = 0, int idDisease = 0, int idTreatment = 0, bool setFilter = false);
    }
}
