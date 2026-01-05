using System.Collections.Generic;
using System.Linq;
using TaskManager.Core.Data;
using TaskManager.Core.Domain;

namespace TaskManager.Tests.Fakes
{
    public class FakeUserRepository : IUserRepository
    {
        public List<User> UsersList { get; set; } = new();

        public void Add(User user)
        {
            UsersList.Add(user);
        }

        public List<User> GetAll()
        {
            return new List<User>(UsersList);
        }

        public User? GetByEmail(string email)
        {
            return UsersList.FirstOrDefault(u => u.Email == email);
        }

        public void SaveAll(List<User> users)
        {
            UsersList = new List<User>(users);
        }
    }
}
