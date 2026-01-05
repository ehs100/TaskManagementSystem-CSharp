using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.WinForm.Data;
using TaskManager.WinForm.Domain;
using TaskManager.WinForm.Security;


namespace TaskManager.WinForm.Service
{


    public class UserService
    {
        private readonly UserRepository _repository;
        private readonly PasswordHasher _hasher = new PasswordHasher(); // Objekt erstellen

        public UserService(UserRepository repository)
        {
            _repository = repository;
        }

        public bool Register(string username, string email, string password, out string message)
        {
            var users = _repository.GetAll();

            if (users.Any(u => u.Email == email))
            {
                message = "Benutzer existiert bereits.";
                return false;
            }

            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                Username = username,
                Email = email,
                PasswordHash = _hasher.Hash(password)   // ✅ Objekt statt Klasse
            };

            users.Add(newUser);
            _repository.SaveAll(users);

            message = "Registrierung erfolgreich!";
            return true;
        }

        public User Login(string email, string password, out string message)
        {
            var users = _repository.GetAll();
            var user = users.FirstOrDefault(u => u.Email == email);

            if (user == null)
            {
                message = "Benutzer nicht gefunden.";
                return null;
            }

            if (!_hasher.Verify(password, user.PasswordHash))   // ✅ Objekt statt Klasse
            {
                message = "Falsches Passwort.";
                return null;
            }

            message = "Login erfolgreich.";
            return user;
        }
    }


}
