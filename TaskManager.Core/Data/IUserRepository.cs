using System.Collections.Generic;
using TaskManager.Core.Domain;

namespace TaskManager.Core.Data
{
    public interface IUserRepository
    {
        void Add(User user);
        User? GetByEmail(string email);
        List<User> GetAll();
        void SaveAll(List<User> users);
    }
}
