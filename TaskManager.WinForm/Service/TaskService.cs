using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.WinForm.Data;
using TaskManager.WinForm.Domain;

namespace TaskManager.WinForm.Service
{
    public class TaskService
    {
        private readonly TaskRepository _repository;

        public TaskService(TaskRepository repository)
        {
            _repository = repository;
        }

        public List<TaskItem> GetAll()
        {
            return _repository.GetAll();
        }

        public TaskItem Create(string title, string description, DateTime? dueDate)
        {
            var tasks = _repository.GetAll();
            var t = new TaskItem
            {
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsDone = false
            };
            tasks.Add(t);
            _repository.SaveAll(tasks);
            return t;
        }

        public bool ToggleDone(string id)
        {
            var tasks = _repository.GetAll();
            var t = tasks.FirstOrDefault(x => x.Id == id);
            if (t == null) return false;
            t.IsDone = !t.IsDone;
            _repository.SaveAll(tasks);
            return true;
        }

        public void Update(TaskItem task)
        {
            var tasks = _repository.GetAll();
            var existing = tasks.FirstOrDefault(t => t.Id == task.Id);
            if (existing != null)
            {
                existing.Title = task.Title;
                existing.Description = task.Description;
                existing.DueDate = task.DueDate;
                existing.IsDone = task.IsDone;
                _repository.SaveAll(tasks);
            }
        }

        public void Delete(string id)
        {
            var tasks = _repository.GetAll();
            var toRemove = tasks.FirstOrDefault(t => t.Id == id);
            if (toRemove != null)
            {
                tasks.Remove(toRemove);
                _repository.SaveAll(tasks);
            }
        }

        public void Add(TaskItem task)
        {
            var tasks = _repository.GetAll();
            task.Id = Guid.NewGuid().ToString();
            tasks.Add(task);
            _repository.SaveAll(tasks);
        }
    }
}
