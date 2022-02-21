using System;

namespace Products
{
    public class Invoice: IPay
    {
        private Product _products;

        public Invoice(Product products)
        {
            _products = products;
        }

        internal void AddProduct(Product product1)
        {
            throw new NotImplementedException();
        }
        public decimal ValueToPay()
        {
            return 0;
        }
        //public override string ToString()
        //{
        //    return $"\n\t{Id} - {Description}" +
        //        $"\n\tQuantity......: {$"{Quantity:N2}",18}" +
        //        $"\n\tPrice.........: {$"{Price:C2}",18}" +
        //        $"\n\tValue.........: {$"{ValueToPay():C2}",18}";
        //}
        
        
    }
}
