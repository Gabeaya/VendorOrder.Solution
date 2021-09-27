using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;



namespace VendorOrder.Tests 
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void SetDescriptionPrice_SetDescription_String()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of Mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedDescription = "Thirty pounds of Mexican sweet bread";
      newOrder.Description = updatedDescription;
      string resultDescribe = newOrder.Description;
      string updatedPrice = "$175.00";
      newOrder.Price = updatedPrice;
      string resultPrice = newOrder.Price;


      //Assert
      Assert.AreEqual(updatedDescription, resultDescribe);
      Assert.AreEqual(updatedPrice, resultPrice);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newOrder = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newOrder, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of Mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder1 = new Order(title, description, price, date);

      string title2 = "Pan Dulces";
      string description2 = "Twenty-five pounds of Mexican sweet bread.";
      string price2 = "$150.00";
      string date2 = "01/21/2016";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};
      
      //Act
      List<Order> result = Order.GetAll();
      

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of Mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder = new Order(title, description, price, date);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectOrderNumber_Order()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of Mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder1 = new Order(title, description, price, date);

      string title2 = "Pan Dulces";
      string description2 = "Twenty-five pounds of Mexican sweet bread.";
      string price2 = "$150.00";
      string date2 = "01/21/2016";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> newList = new List<Order> {newOrder1, newOrder2};

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}