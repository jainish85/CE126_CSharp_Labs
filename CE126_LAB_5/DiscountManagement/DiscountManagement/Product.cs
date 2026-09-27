namespace DiscountManagement
{
    public class Product
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public double DiscountPercentage { get; set; }
    }
}