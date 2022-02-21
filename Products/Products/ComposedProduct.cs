using System;
using System.Collections.Generic;

namespace Products
{
    public class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public ICollection<Product> Products;
        public string names { get; set; }


        public override decimal ValuetoPay()
        {
            decimal payroll=0;
            decimal total1 = 0;
            decimal total2 = 0;
            foreach (Product product in Products)
            {
                payroll += product.ValuetoPay();
                names += product.Description + " ";
            }
            total1 = payroll * (decimal)Discount;
            total2 = payroll - total1;
            return total2;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tProducts.......: {names}" +
                $"\n\tDiscaunt.......: {$"{Discount:P2}",15}" +
                $"\n\tValue..........: {$"{ValuetoPay():C2}",15}";
        }
    }
}
