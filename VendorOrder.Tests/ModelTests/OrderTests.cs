using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;


namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Pan Dulces";
      Order newOrder = new Order(title);
      //Act
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(title, result);
    }
  }
}