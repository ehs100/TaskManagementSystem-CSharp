using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.Security;


namespace TaskManager.Core.Security
{
    public  class PasswordHasher
    {


        // Passworthash erstellen (SHA256, Base64)
        public string Hash(string password)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes(password ?? "");
                var hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        // Passwort prüfen: eingegebenes Passwort gegen gespeicherten Hash
        public  bool Verify(string password, string storedHash)
        {
            var newHash = Hash(password);
            return string.Equals(newHash, storedHash, StringComparison.Ordinal);
        }
    }
}

