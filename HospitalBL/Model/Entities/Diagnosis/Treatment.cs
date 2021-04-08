using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HospitalBL.Model.Entities.Diagnosis
{
    public class Treatment: IEntity, INotifyPropertyChanged, IEquatable<Treatment>
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description  { get; set; }
        public int Disease { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public Treatment(string name, int disease, string description = "Описание отсутсвует")
        {
            Name = GetValidName(name);
            Description = description;
            Disease = disease;
        }


        public void Edit(object obj)
        {
            if ((obj is Treatment treatment) && !(treatment is null))
            {
                Name = treatment.Name;
                Description = treatment.Description;
            }
        }

        private string GetValidName(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
                return str.First().ToString().ToUpper() + str.Remove(0, 1).ToLower().Trim();
            else return string.Empty;
        }
        #endregion

        #region Oveerride
        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Treatment);
        }

        public bool Equals(Treatment other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&
                   Description == other.Description &&
                   Disease == other.Disease;
        }

        public override int GetHashCode()
        {
            int hashCode = 2145500380;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<int>.Default.GetHashCode(Disease);
            return hashCode;
        }

        public static bool operator ==(Treatment left, Treatment right)
        {
            return EqualityComparer<Treatment>.Default.Equals(left, right);
        }

        public static bool operator !=(Treatment left, Treatment right)
        {
            return !(left == right);
        }
        #endregion
    }
}
