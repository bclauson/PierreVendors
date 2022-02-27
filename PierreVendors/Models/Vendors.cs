using System.Collections.Generic;

namespace PierreVendors.Models
{
  public class Vendors
  {

    private static List<Vendors> _instances = new List<Vendors> {};
    public string Vendor { get; set; }
    public int Id { get; }
    public List<Order> Orders { get; set; }

    public Vendors(string vendorName)
    {
      Vendor = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll() 
    {
      _instances.Clear();
    }

    public static List<Vendors> GetAll()
    {
      return _instances;
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static Vendors Find(int searchId)
    {
      return _instances[searchId - 1];
    }


  }

  


}