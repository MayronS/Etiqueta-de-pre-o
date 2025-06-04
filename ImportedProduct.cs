using System;
using System.Globalization;
namespace Products
{
    public class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public double totalPrice()
        {
            return customsFee + price;

        }

        public override string priceTag()
        {
            return $"{name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: $ {customsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }
        public ImportedProduct()
        {

        }
    }
}