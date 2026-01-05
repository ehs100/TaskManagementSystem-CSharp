using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TaskManager.WinForm.Data
{
    public class JsonFileRepository<T>
    {
        private readonly string _filePath;

        public JsonFileRepository(string filePath)
        {
            _filePath = filePath;
        }

        public virtual List<T> GetAll()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            return JsonConvert.DeserializeObject<List<T>>(json)
                   ?? new List<T>();
        }

        public virtual void SaveAll(List<T> items)
        {
            var json = JsonConvert.SerializeObject(items, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
