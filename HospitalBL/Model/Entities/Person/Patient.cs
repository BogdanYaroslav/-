using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalBL.Model.Entities.Person
{
    public class Patient: Person, INotifyPropertyChanged
    {
        #region Property
        


        #endregion

        #region Methods
        public Patient(string name, string surname, Genders gender, string phone, DateTime birthday)
            : base(name, surname, gender, phone, birthday)
        {}

        public override void Edit(object obj)
        {
            if ((obj is Patient patient) && !(patient is null))
            {
                base.Edit(patient);
            }
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Patient);
        }

        public bool Equals(Patient other)
        {
            return other != null &&
                   base.Equals(other);
        }

        public override int GetHashCode()
        {
            int hashCode = -230095580;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Patient left, Patient right)
        {
            return EqualityComparer<Patient>.Default.Equals(left, right);
        }

        public static bool operator !=(Patient left, Patient right)
        {
            return !(left == right);
        }

        #endregion


    }
}
