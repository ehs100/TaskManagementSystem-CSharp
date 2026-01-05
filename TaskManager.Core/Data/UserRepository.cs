using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using TaskManager.Core.Domain;

namespace TaskManager.Core.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly string _filePath;

        public UserRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<User> GetAll()
        {
            if (!File.Exists(_filePath))
                return new List<User>();

            string json = File.ReadAllText(_filePath);

            if (string.IsNullOrWhiteSpace(json))
                return new List<User>();

            return JsonSerializer.Deserialize<List<User>>(json)
                   ?? new List<User>();
        }

        public void SaveAll(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_filePath, json);
        }

        public void Add(User user)
        {
            var users = GetAll();
            users.Add(user);
            SaveAll(users);
        }

        public User? GetByEmail(string email)
        {
            return GetAll().FirstOrDefault(u => u.Email == email);
        }
    }
}
