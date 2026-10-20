using MyFirstApp.Controllers;
using System.Web.Mvc;

namespace MyFirstApp.Tests
{
    [TestClass]
    public sealed class HomeControllerTests
    {
        [TestMethod]
        public void Index_ShouldReturnView()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }
    }
}
