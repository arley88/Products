using System.Collections.Generic;

namespace Products
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection<Product> Products;

        public override decimal ValueToPay()
        {
            decimal payroll = 0;
            decimal total1 = 0;
            decimal total2 = 0;
            foreach (Product product in Products)
            {
                payroll += product.ValueToPay();
            }
            total1 = payroll * (decimal)Discount;
            total2 = payroll - total1;

            return total2;
        }
        public string Names()
        {
            string names = "";
            foreach (Product product in Products)
            {
                names += ", "+product.Description;
            }
            return names;
        }

        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tProducts..: {Names()}" +
                $"\n\tDiscaunt..: {$"{Discount:P2}",15}" +
                $"\n\tValue.....: {$"{ValueToPay():C2}",15}";
        }
    }
}
