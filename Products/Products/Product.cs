namespace Products
{
    public abstract class Product: IPay
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public int Id { get; set; }

        public abstract decimal ValueToPay();

        public override string ToString()
        {
            return $"{Id} " +
                $"{Price} " +
                $"{Tax} " +
                $"{Description}";
        }
    }
}
