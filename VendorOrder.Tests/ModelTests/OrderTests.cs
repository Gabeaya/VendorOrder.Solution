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
      Order newOrder = new Order("Pan Dulces", "25 pounds of bread","$150.00", "01/21/16");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void OrderConstructor_CreatesAnInstanceOfAnOrder_True()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder = new Order(title, description, price, date);
      //Act
      string instanceTitle = newOrder.Title;
      string instanceDescription = newOrder.Description;
      string instancePrice = newOrder.Price;
      string instanceDate = newOrder.Date;
      //Assert
      Assert.AreEqual(title, instanceTitle);
      Assert.AreEqual(description, instanceDescription);
      Assert.AreEqual(price, instancePrice);
      Assert.AreEqual(date, instanceDate);
    }
  }
}