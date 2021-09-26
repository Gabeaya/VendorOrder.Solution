using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    private static List<Order> _instances = new List<Order> {};
    //Constructor
    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}