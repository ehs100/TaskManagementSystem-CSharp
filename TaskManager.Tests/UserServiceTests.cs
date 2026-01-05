using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Core.Service;
using TaskManager.Core.Domain;
using TaskManager.Tests.Fakes;

namespace TaskManager.Tests
{
    [TestClass]
    public class UserServiceTests
    {
        private FakeUserRepository _repo;
        private UserService _service;

        [TestInitialize]
        public void Setup()
        {
            _repo = new FakeUserRepository();
            _service = new UserService(_repo);
        }

        [TestMethod]
        public void Register_Adds_New_User()
        {
            string msg;
            bool ok = _service.Register("max", "max@test.de", "pass123", out msg);

            Assert.IsTrue(ok);
            Assert.AreEqual(1, _repo.UsersList.Count);
            Assert.AreEqual("max@test.de", _repo.UsersList[0].Email);
        }

        [TestMethod]
        public void Register_Duplicate_Email_Returns_False()
        {
            string msg;
            _service.Register("max", "max@test.de", "pass123", out msg);

            string msg2;
            bool ok2 = _service.Register("max2", "max@test.de", "pass999", out msg2);

            Assert.IsFalse(ok2);
            Assert.AreEqual(1, _repo.UsersList.Count);
        }

        [TestMethod]
        public void Login_Correct_Password_Returns_User()
        {
            string msg;
            _service.Register("max", "max@test.de", "pass123", out msg);

            string loginMsg;
            User? user = _service.Login("max@test.de", "pass123", out loginMsg);

            Assert.IsNotNull(user);
            Assert.AreEqual("max", user.Username);
        }

        [TestMethod]
        public void Login_Wrong_Password_Returns_Null()
        {
            string msg;
            _service.Register("max", "max@test.de", "pass123", out msg);

            string loginMsg;
            var user = _service.Login("max@test.de", "WRONG", out loginMsg);

            Assert.IsNull(user);
        }

        [TestMethod]
        public void Login_Unknown_Email_Returns_Null()
        {
            string msg;
            var user = _service.Login("unknown@test.de", "test", out msg);

            Assert.IsNull(user);
        }
    }
}
