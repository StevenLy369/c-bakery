using System.Collections.Generic;
using System;


namespace Bakery.Models
{
  public class Order
  {

    public string Description {get; set;}
    public string Date {get;set;}
    public int Price {get;set;}
    public string Title {get;set;}
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};
   
    public Order(string description, string date, int price, string title)
    {
        Description = description;
        Date = date;
        Price = price;
        Title = title;
        _instances.Add(this);
     
    }

    public static List<Order> GetAll()
    {
        return _instances;
    }
    
  
 
  }
}