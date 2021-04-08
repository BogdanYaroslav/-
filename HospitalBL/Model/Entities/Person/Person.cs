using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace HospitalBL.Model.Entities.Person
{
    public abstract class Person : IEquatable<Person>, IEntity, INotifyPropertyChanged
    {
        #region Property
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public Genders Gender { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get
            {
                DateTime nowDate = DateTime.Today;
                int age = nowDate.Year - Birthday.Year;
                if (nowDate.Month < Birthday.Month || (nowDate.Month == Birthday.Month && nowDate.Day < Birthday.Day)) age--;
                return age;
            }
        }
        public string FullName { get { return $"{Name} {Surname}"; } }


        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region Methods
        public Person(string name, string surname, Genders gender, string phone, DateTime birthday)
        {            

            Name = GetValidNameAndSurname(name);
            Surname = GetValidNameAndSurname(surname);
            Gender = gender;
            Phone = phone;
            Birthday = birthday.Date;
           
        }

        public virtual void Edit(object obj)
        {
            if((obj is Person person) && !(person is null))
            {
                Name = person.Name;
                Surname = person.Surname;
                Phone = person.Phone;
                Gender = person.Gender;
                Birthday = person.Birthday;
            }
        }

        private string GetValidNameAndSurname(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
                return str.First().ToString().ToUpper() + str.Remove(0, 1).ToLower().Trim();
            else return string.Empty;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return FullName;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null && this != null &&
                   Phone == other.Phone &&
                   FullName == other.FullName;
        }

        public override int GetHashCode()
        {
            int hashCode = 1327366762;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Surname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Phone);
            hashCode = hashCode * -1521134295 + Gender.GetHashCode();
            hashCode = hashCode * -1521134295 + Birthday.GetHashCode();
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullName);
            return hashCode;
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
        #endregion
    }
}
