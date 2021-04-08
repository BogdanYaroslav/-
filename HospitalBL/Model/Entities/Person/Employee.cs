using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HospitalBL.Model.Entities.Person
{
    public class Employee : Person, IEquatable<Employee>, INotifyPropertyChanged
    {
        #region Property
        public Profile Profile { get; set; }
        public UserRole Role { get; set; }
        #endregion

        #region Methods
        public Employee(string login, string password, UserRole role, string name, string surname, Genders gender, string phone, DateTime birthday, UserPriority priority = UserPriority.Отсутсвует)
            : base(name, surname, gender, phone, birthday)
        {
            Profile = new Profile(login, password, priority);
            Profile.Id = Id;
            Role = role;
        }

        public override void Edit(object obj)
        {
            if ((obj is Employee employee) && !(employee is null))
            {
                base.Edit(employee);
                Profile.Edit(employee.Profile);
                Role = employee.Role;
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
            return Equals(obj as Employee);
        }

        public bool Equals(Employee other)
        {
            return other != null &&
                   base.Equals(other) &&
                   EqualityComparer<Profile>.Default.Equals(Profile, other.Profile);
        }

        public override int GetHashCode()
        {
            int hashCode = -230095580;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Profile>.Default.GetHashCode(Profile);
            return hashCode;
        }

        public static bool operator ==(Employee left, Employee right)
        {
            return EqualityComparer<Employee>.Default.Equals(left, right);
        }

        public static bool operator !=(Employee left, Employee right)
        {
            return !(left == right);
        }
        #endregion
    }
}
