using System.Collections.Generic;

namespace Products
{
    public class Invoice : IPay
    {
        private ICollection<Product> _products;

        public Invoice()
        {
            _products = new List<Product>();
        }

        internal void AddProduct(Product product1)
        {
                _products.Add(product1);
        }
        public decimal ValueToPay()
        {
            decimal payroll = 0;
            foreach (Product product in _products)
            {
                payroll += product.ValuetoPay();
            }
            return payroll;
        }
        public override string ToString()
        {
            string text = $"RECEIPT " +
                $"\n-------------------------------------------------";
            foreach (Product product in _products)
            {
                text += $"\n" + product.ToString();
            }
            return $"{text}" +
                $"\n\t\t   ================"+
                $"\nTOTAL:              {$"{ValueToPay():C2}",15}"; ;
        }


    }
}
