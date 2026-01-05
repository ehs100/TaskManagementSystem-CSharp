using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManager.Core.Service;
using TaskManager.Core.Domain;
using TaskManager.Tests.Fakes;

namespace TaskManager.Tests
{
    [TestClass]
    public class TaskServiceTests
    {
        [TestMethod]
        public void Create_Adds_Task_To_Repository()
        {
            // Arrange
            var repo = new FakeTaskRepository();
            var service = new TaskService(repo);

            // Act
            var t = service.Create("Test", "Desc", null);

            // Assert
            Assert.AreEqual(1, repo.Items.Count);
            Assert.AreEqual("Test", repo.Items[0].Title);
        }
    }
}
