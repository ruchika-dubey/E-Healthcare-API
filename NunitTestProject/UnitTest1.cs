using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAPI.Controllers;

namespace NUnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
          
           
                // Arrange
                var controller = new AdminController(repository);
                controller.Request = new HttpRequestMessage();
                controller.Configuration = new HttpConfiguration();

                // Act
                var response = controller.Get(10);

                // Assert
                Product product;
                Assert.IsTrue(response.TryGetContentValue<Product>(out product));
                Assert.AreEqual(10, product.Id);
          
        }
    }
}
