using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaskManager.Core.Data
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

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        public virtual void SaveAll(List<T> items)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true // schön formatiert
            };

            var json = JsonSerializer.Serialize(items, options);
            File.WriteAllText(_filePath, json);
        }
    }
}
