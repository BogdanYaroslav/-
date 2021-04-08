using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HospitalBL.Model.Entities.Diagnosis
{
    public class Disease: IEntity, INotifyPropertyChanged
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public Disease(string name, string description = "Описание отсутсвует")
        {
            Name = GetValidName(name);
            Description = description;
        }

        public void Edit(object obj)
        {
            if ((obj is Disease productGroup) && !(productGroup is null))
            {
                Name = productGroup.Name;
                Description = productGroup.Description;
            }
        }
        
        private string GetValidName(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
                return str.First().ToString().ToUpper() + str.Remove(0, 1).ToLower().Trim();
            else return string.Empty;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Disease);
        }

        public bool Equals(Disease other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&                   
                   Description == other.Description;
        }

        public override int GetHashCode()
        {
            int hashCode = -1310195071;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }

        public static bool operator ==(Disease left, Disease right)
        {
            return EqualityComparer<Disease>.Default.Equals(left, right);
        }

        public static bool operator !=(Disease left, Disease right)
        {
            return !(left == right);
        }

        #endregion
    }
}
