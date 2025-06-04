using System;
using Products;

namespace Program
{

  public class Program
  {
    public static void Main(String[] args)
    {
      int numeroProdutos;
      List<Product> Produtos = new List<Product>();

      Console.WriteLine("Enter the number of products: ");
      numeroProdutos = int.Parse(Console.ReadLine());

      for (int i = 0; i < numeroProdutos; i++)
      {
        char type;
        string name;
        double price;
        double customsFee;
        DateTime manufactureDate;
        Console.WriteLine($"Product #{i + 1} data:");
        Console.Write("Commun, used, or imported (c/u/i)? ");
        type = char.Parse(Console.ReadLine());

        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Price: ");
        price = double.Parse(Console.ReadLine());
        if (type == 'c')
        {
          Produtos.Add(new Product(name, price));
        }

        else if (type == 'u')
        {
          Console.Write($"Manufacture date (DD/MM/YYYY): ");
          manufactureDate = DateTime.Parse(Console.ReadLine());
          Produtos.Add(new UsedProduct(name, price, manufactureDate));

        }
        else if (type == 'i')
        {
          Console.Write("Customs fee: ");
          customsFee = double.Parse(Console.ReadLine());
          Produtos.Add(new ImportedProduct(name, price, customsFee));
        }

      }
      foreach (Product obj in Produtos)
      {
        Console.WriteLine(obj.priceTag());
      }

    }
  }
}
