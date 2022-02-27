namespace Products
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            decimal totalPrice = Price + (Price * (decimal)Tax);
            return totalPrice;
        }
        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tPrice.....: {$"{Price:C2}",15}" +
                $"\n\tTax.......: {$"{Tax:P2}",15}" +
                $"\n\tValue.....: {$"{ValueToPay():C2}",15}";
        }
    }
}
