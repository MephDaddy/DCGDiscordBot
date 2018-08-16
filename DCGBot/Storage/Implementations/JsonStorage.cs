using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DCGBot.Storage.Implementations
{
    public class JsonStorage : IDataStorage
    {
        public T RestoreObject<T>(string key)
        {
            var json = File.ReadAllText($"{key}.json");
            return JsonConvert.DeserializeObject<T>(json);
        }

        public void StoreObject(object obj, string key)
        {
            var file = $"{key}.json";
            Directory.CreateDirectory(Path.GetDirectoryName(file));
            var json = JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);
        }
    }
}
