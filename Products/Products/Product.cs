namespace Products
{
    public abstract class Product
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }
        public int Id { get; set; }

        public abstract decimal ValuetoPay();

        public override string ToString()
        {
            return $"{Id} " +
                $"{Price} " +
                $"{Tax} " +
                $"{Description}";
        }

    }
}
