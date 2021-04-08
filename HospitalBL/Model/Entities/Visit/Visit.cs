using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HospitalBL.Model.Entities.Visit
{
    public class Visit : IEntity, INotifyPropertyChanged, IEquatable<Visit>
    {

        #region Property
        public int Id { get; set; }        
        public int Doctor { get; set; }
        public int Patient { get; set; }        
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Day { get { return Date.Day; } }
        public int Mounth { get { return Date.Month; } }
        public int Year { get { return Date.Year; } }

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
        
        #region Methods
        public Visit()
        {

        }

        public Visit(int doctor, int patient, DateTime date, TimeSpan time)
        {
            Doctor = doctor;
            Patient = patient;
            Date = date.Date;
            Time = time;
        }

        public void Edit(object obj)
        {
            if ((obj is Visit visit) && !(visit is null))
            {
                Doctor = visit.Doctor;
                Patient = visit.Patient;
                Date = visit.Date;
                Time = visit.Time;
            }
        }

        #endregion

        #region Override
        public override string ToString()
        {
            return $"{Id} {Date} {Time}";
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Visit);
        }

        public bool Equals(Visit other)
        {
            return other != null &&
                   Id == other.Id &&
                   Doctor == other.Doctor &&
                   Patient == other.Patient &&
                   Date == other.Date &&
                   Time.Equals(other.Time);
        }

        public override int GetHashCode()
        {
            int hashCode = -1139595855;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + Doctor.GetHashCode();
            hashCode = hashCode * -1521134295 + Patient.GetHashCode();
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + Time.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Visit left, Visit right)
        {
            return EqualityComparer<Visit>.Default.Equals(left, right);
        }

        public static bool operator !=(Visit left, Visit right)
        {
            return !(left == right);
        }



        #endregion

    }
}
