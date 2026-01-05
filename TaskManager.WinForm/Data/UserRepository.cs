using TaskManager.WinForm.Domain;
using TaskManager.WinForm.Data;

namespace TaskManager.WinForm.Data
{
    public class UserRepository : JsonFileRepository<User>
    {
        public UserRepository(string path) : base(path) { }
    }
}

