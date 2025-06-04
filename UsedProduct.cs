using System;
using System.Globalization;

namespace Products
{

  public class UsedProduct : Product
  {
    public DateTime manufactureDate { get; set; }
    public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
    {
      this.manufactureDate = manufactureDate;
    }
    public UsedProduct()
    {

    }


    public override string priceTag()
    {
      return $"Iphone (used) $ {price.ToString("F2", CultureInfo.InvariantCulture)} (Manufacture date: {manufactureDate.ToString("dd/MM/yyyy")})";
    }
  }
}