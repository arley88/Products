using System;

namespace Products
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }

        public override decimal ValuetoPay()
        {
            decimal total1 = Price * (decimal)Quantity;
            decimal total2 = total1 * (decimal)Tax;
            decimal total3 = total2 + total1;
            return total3;
        }

        public override string ToString()
        {
            return $"{Id} - {Description}" +
                $"\n\tMeasument.: {Measurement}" +
                $"\n\tQuantity..: {$"{Quantity:N2}",15}" +
                $"\n\tPrice.....: {$"{Price:C2}",15}" +
                $"\n\tTax.......: {$"{Tax:P2}",15}" +
                $"\n\tValue.....: {$"{ValuetoPay():C2}",15}"; ;
        }
    }
}
