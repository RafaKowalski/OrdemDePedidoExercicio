namespace OrdemDePedido.Entities
{
    public class Product
    {
        public string ProductName { get; set; }

        public double ProductPrice { get; set; }

        public Product()
        {
        }

        public Product(string productName, double productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
    }
}
