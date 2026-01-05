using System.Collections.Generic;
using TaskManager.Core.Domain;

namespace TaskManager.Core.Data
{
    public interface ITaskRepository
    {
        List<TaskItem> GetAll();
        TaskItem? GetById(string id);
        void Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(string id);
        void SaveAll(List<TaskItem> tasks);
    }
}
