using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace HospitalBL.Model.Entities.Person
{
    public class Profile : IEquatable<Profile>, IEntity, INotifyPropertyChanged
    {
        #region Property
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserPriority Priority { get; set; }

        #endregion

        #region Methods

        public Profile(string login, string password, UserPriority priority = UserPriority.Отсутсвует)
        {
            Login = login;
            Password = password;
            Priority = priority; 
        }

        public void Edit(object obj)
        {
            if ((obj is Profile profile) && !(profile is null))
            {
                Login = profile.Login;
                Password = profile.Password;
                Priority = profile.Priority;
            }
        }

        #endregion

        #region Override
        public override bool Equals(object obj)
        {
            return Equals(obj as Profile);
        }

        public bool Equals(Profile other)
        {
            return other != null &&
                   Login == other.Login &&
                   Password == other.Password;
        }

        public override int GetHashCode()
        {
            int hashCode = -1780185382;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Login);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }

        public static bool operator ==(Profile left, Profile right)
        {
            return EqualityComparer<Profile>.Default.Equals(left, right);
        }

        public static bool operator !=(Profile left, Profile right)
        {
            return !(left == right);
        }
        #endregion
    }
}
