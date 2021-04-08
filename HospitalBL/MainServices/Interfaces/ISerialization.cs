using System.Collections.Generic;

namespace HospitalBL.MainServices.Interfaces
{
    public interface ISerialization
    {       
        IEnumerable<T> DeserializeCollection<T>() where T : class;
        void SerializeCollection<T>(IEnumerable<T> data) where T:class;
    }
}
