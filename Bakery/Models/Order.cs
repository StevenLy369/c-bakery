using System.Collections.Generic;
using System;


namespace Bakery.Models
{
  public class Order
  {

    public string Description {get; set;}
    
    public int Id { get; }
    private static List<Order> _instances = new List<Order>{};
   
    public Order(string description)
    {
        Description = description;
        _instances.Add(this);
        Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
        return _instances;
    }
    
  
 
  }
}