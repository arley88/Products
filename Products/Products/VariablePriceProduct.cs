namespace Products
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValueToPay()
        {
            decimal total1 = Price * (decimal)Quantity;
            return (total1 * (decimal)Tax) + total1;
        }


        public override string ToString()
        {
            return $"   {Id} {Description}" +
                $"\n\tMeasument.: {Measurement}" +
                $"\n\tQuantity..: {$"{Quantity:N2}",15}" +
                $"\n\tPrice.....: {$"{Price:C2}",15}" +
                $"\n\tTax.......: {$"{Tax:P2}",15}" +
                $"\n\tValue.....: {$"{ValueToPay():C2}",15}"; ;
        }
    }
}
