using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Core.Data;
using TaskManager.Core.Domain;

namespace TaskManager.Core.Service
{
    public class TaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        // ---------------------------------------------------------
        // 1) Alle Aufgaben abrufen
        // ---------------------------------------------------------
        public List<TaskItem> GetAll()
        {
            return _repository.GetAll();
        }

        // ---------------------------------------------------------
        // 2) Aufgabe per Id abrufen
        // ---------------------------------------------------------
        public TaskItem? GetById(string id)
        {
            return _repository.GetById(id);
        }

        // ---------------------------------------------------------
        // 3) Neue Aufgabe erstellen
        // ---------------------------------------------------------
        public TaskItem Create(string title, string description, DateTime? dueDate)
        {
            var task = new TaskItem
            {
                Id = Guid.NewGuid().ToString(),
                Title = title,
                Description = description,
                DueDate = dueDate,
                IsDone = false
            };

            _repository.Add(task);
            return task;
        }

        // ---------------------------------------------------------
        // 4) Status (done / not done) umschalten
        // ---------------------------------------------------------
        public bool ToggleDone(string id)
        {
            var task = _repository.GetById(id);

            if (task == null)
                return false;

            task.IsDone = !task.IsDone;

            _repository.Update(task);
            return true;
        }

        // ---------------------------------------------------------
        // 5) Aufgabe aktualisieren
        // ---------------------------------------------------------
        public bool Update(TaskItem updated)
        {
            var existing = _repository.GetById(updated.Id);

            if (existing == null)
                return false;

            existing.Title = updated.Title;
            existing.Description = updated.Description;
            existing.DueDate = updated.DueDate;
            existing.IsDone = updated.IsDone;

            _repository.Update(existing);
            return true;
        }

        // ---------------------------------------------------------
        // 6) Aufgabe löschen
        // ---------------------------------------------------------
        public bool Delete(string id)
        {
            var task = _repository.GetById(id);

            if (task == null)
                return false;

            _repository.Delete(id);
            return true;
        }

        // ---------------------------------------------------------
        // 7) Bereits fertiges TaskItem hinzufügen (optional)
        // ---------------------------------------------------------
        public void Add(TaskItem item)
        {
            _repository.Add(item);
        }
    }
}
