using TaskManager.Core.Data;
using TaskManager.Core.Domain;
using TaskManager.Core.Security;

namespace TaskManager.Core.Service
{
    public class UserService
    {
        private readonly IUserRepository _repository;
        private readonly PasswordHasher _hasher = new PasswordHasher();

        public UserService(IUserRepository repository)
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
                PasswordHash = _hasher.Hash(password)
            };

            _repository.Add(newUser);
            message = "Registrierung erfolgreich!";
            return true;
        }

        public User? Login(string email, string password, out string message)
        {
            var user = _repository.GetByEmail(email);

            if (user == null)
            {
                message = "Benutzer nicht gefunden.";
                return null;
            }

            if (!_hasher.Verify(password, user.PasswordHash))
            {
                message = "Falsches Passwort.";
                return null;
            }

            message = "Login erfolgreich.";
            return user;
        }
    }
}
