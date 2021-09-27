using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.TestTools
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod] public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "Test Description";
      Vendor newVendor = new Vendor(name, description);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "test";
      string name2 = "test2";
      string description1 = "this is test";
      string description2 = "this is test 2";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      List<Vendor> newList = new List<Vendor> {newVendor1, newVendor2};
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "test";
      string name2 = "test2";
      string description1 = "this is test";
      string description2 = "this is test 2";
      Vendor newVendor1 = new Vendor(name1, description1);
      Vendor newVendor2 = new Vendor(name2, description2);
      //Act
      Vendor result = Vendor.Find(2);
      //Assert
      Assert.AreEqual(newVendor2, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Pan Dulces";
      string description = "Twenty-five pounds of mexican sweet bread.";
      string price = "$150.00";
      string date = "01/21/2016";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList =  new List<Order>{ newOrder };

      string vendorName = "Test Vendor";
      string vendorDescription = "Test Description";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);

      //Act
      List<Order> result = newVendor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}