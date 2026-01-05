using System.Collections.Generic;
using System.Linq;
using TaskManager.Core.Data;
using TaskManager.Core.Domain;

namespace TaskManager.Tests.Fakes
{
    public class FakeTaskRepository : ITaskRepository
    {
        public List<TaskItem> Items { get; private set; } = new List<TaskItem>();

        public List<TaskItem> GetAll()
        {
            return Items;
        }

        public TaskItem? GetById(string id)
        {
            return Items.FirstOrDefault(t => t.Id == id);
        }

        public void Add(TaskItem task)
        {
            Items.Add(task);
        }

        public void Update(TaskItem task)
        {
            var existing = Items.FirstOrDefault(t => t.Id == task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
                existing.DueDate = task.DueDate;
                existing.IsDone = task.IsDone;
            }
        }

        public void Delete(string id)
        {
            var t = Items.FirstOrDefault(x => x.Id == id);
            if (t != null)
                Items.Remove(t);
        }

        public void SaveAll(List<TaskItem> tasks)
        {
            Items = tasks;
        }
    }
}
