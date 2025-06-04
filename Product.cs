using System;
using System.Globalization;

namespace Products
{
  public class Product
  {
    public string name { get; set; }
    public double price { get; set; }

    public Product(string name, double price)
    {
      this.name = name;
      this.price = price;
    }
    public Product()
    { }

    public virtual string priceTag()
    {
      return $"{name} $ {price.ToString("F2", CultureInfo.InvariantCulture)}";
    }
  }
}