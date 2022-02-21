namespace Products
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            decimal precioTotal = Price + (Price * (decimal)Tax);
            return precioTotal;
        }
        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tPrice.....: {$"{Price:C2}", 15}" +
                $"\n\tTax.......: {$"{Tax:P2}", 15}" +
                $"\n\tValue.....: {$"{ValueToPay():C2}",15}";
        }
    }
}
