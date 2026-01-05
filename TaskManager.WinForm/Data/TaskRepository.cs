using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TaskManager.WinForm.Domain;

namespace TaskManager.WinForm.Data
{
    public class TaskRepository
    {
        private readonly string _filePath;

        public TaskRepository(string filePath)
        {
            _filePath = filePath;
        }

        public virtual List<TaskItem> GetAll()
        {
            if (!File.Exists(_filePath))
                return new List<TaskItem>();

            var json = File.ReadAllText(_filePath);

            return string.IsNullOrWhiteSpace(json)
                ? new List<TaskItem>()
                : JsonConvert.DeserializeObject<List<TaskItem>>(json) ?? new List<TaskItem>();
        }

        public virtual void SaveAll(List<TaskItem> tasks)
        {
            var json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
            File.WriteAllText(_filePath, json);
        }
    }
}
