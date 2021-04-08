using HospitalBL.MainServices.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HospitalBL.MainServices
{
    class JsonSerializationService : ISerialization
    {
        public IEnumerable<T> DeserializeCollection<T>() where T : class
        {
            string dir = "Save";
            string FileName = Path.ChangeExtension(Path.Combine(dir, typeof(T).Name + "_Json"), "fs");

            if (File.Exists(FileName))
            {
                using (var f = File.OpenText(FileName))
                {
                    var json = f.ReadToEnd();
                    return JsonConvert.DeserializeObject<BindingListView<T>>(json,
                                new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });
                }
            }
            else return default;
        }

        public void SerializeCollection<T>(IEnumerable<T> data) where T : class
        {
            string dir = "Save";
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            string FileName = Path.ChangeExtension(Path.Combine(dir,typeof(T).Name + "_Json"), "fs");

            var json = JsonConvert.SerializeObject(data, Formatting.Indented,
                            new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.All });

            using (var f = File.CreateText(FileName))
            {
                f.Write(json);
            }
        }

    }
}
