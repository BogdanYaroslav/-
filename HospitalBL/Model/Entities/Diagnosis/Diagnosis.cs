using HospitalBL.MainServices;
using HospitalBL.Model.Entities.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HospitalBL.Model.Entities.Diagnosis
{
    public class Diagnosis : IEntity, INotifyPropertyChanged, IEquatable<Diagnosis>
    {
        #region Property
        public int Id { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public int DiseaseID { get; set; }
        public int TreatmentID { get; set; }
        public DateTime Date { get; set; }
        public int Day { get { return Date.Day; } }
        public int Mounth { get { return Date.Month; } }
        public int Year { get { return Date.Year; } }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public Diagnosis(int patient, int doctor, int disease, int treatment, DateTime date)
        {
            PatientID = patient;
            DoctorID = doctor;
            DiseaseID = disease;
            TreatmentID = treatment;
            Date = date.Date;
        }

        public void Edit(object obj)
        {
            if ((obj is Diagnosis diagnosis) && !(diagnosis is null))
            {
                PatientID = diagnosis.PatientID;
                DoctorID = diagnosis.DoctorID;
                DiseaseID = diagnosis.DiseaseID;
                TreatmentID = diagnosis.TreatmentID;
                Date = diagnosis.Date;
            }
        }
        #endregion

        #region Override    
        
        public override bool Equals(object obj)
        {
            return Equals(obj as Diagnosis);
        }

        public bool Equals(Diagnosis other)
        {
            return other != null &&
                   Id == other.Id &&
                   PatientID == other.PatientID &&
                   DoctorID == other.DoctorID &&
                   DiseaseID == other.DiseaseID &&
                   TreatmentID == other.TreatmentID &&
                   Date == other.Date;
        }

        public override int GetHashCode()
        {
            int hashCode = -1986329711;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + PatientID.GetHashCode();
            hashCode = hashCode * -1521134295 + DoctorID.GetHashCode();
            hashCode = hashCode * -1521134295 + DiseaseID.GetHashCode();
            hashCode = hashCode * -1521134295 + TreatmentID.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Diagnosis left, Diagnosis right)
        {
            return EqualityComparer<Diagnosis>.Default.Equals(left, right);
        }

        public static bool operator !=(Diagnosis left, Diagnosis right)
        {
            return !(left == right);
        }
        #endregion
    }
}
