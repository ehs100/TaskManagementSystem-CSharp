using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TaskManager.Core.Domain;
using TaskManager.Core.Data;

namespace TaskManager.Core.Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly string _filePath;

        public TaskRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<TaskItem> GetAll()
        {
            if (!File.Exists(_filePath))
                return new List<TaskItem>();

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<TaskItem>();

            return JsonSerializer.Deserialize<List<TaskItem>>(json)
                ?? new List<TaskItem>();
        }

        public TaskItem? GetById(string id)
        {
            return GetAll().FirstOrDefault(t => t.Id == id);
        }

        public void Add(TaskItem task)
        {
            var tasks = GetAll();
            tasks.Add(task);
            SaveAll(tasks);
        }

        public void Update(TaskItem task)
        {
            var tasks = GetAll();
            var existing = tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
                existing.DueDate = task.DueDate;
                existing.IsDone = task.IsDone;

                SaveAll(tasks);
            }
        }

        public void Delete(string id)
        {
            var tasks = GetAll();
            var toDelete = tasks.FirstOrDefault(t => t.Id == id);

            if (toDelete != null)
            {
                tasks.Remove(toDelete);
                SaveAll(tasks);
            }
        }

        public void SaveAll(List<TaskItem> tasks)
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_filePath, json);
        }
    }
}
