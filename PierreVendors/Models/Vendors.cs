using System.Collections.Generic;

namespace PierreVendors.Models
{
  public class Vendors
  {

    private static List<Vendors> _instances = new List<Vendors> {};
    public string Vendor { get; set; }
    public int Id { get; }

    public Vendors(string vendorName)
    {
      Vendor = vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static void ClearAll() 
    {
      _instances.Clear();
    }


  }

  


}