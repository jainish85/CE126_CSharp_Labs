using System;
using System.Collections.Generic;

namespace DiscountManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Store all products in List<Product>
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Laptop",
                    Category = "Electronics",
                    Price = 50000,
                    DiscountPercentage = 10
                },

                new Product
                {
                    ProductID = 2,
                    ProductName = "Mobile",
                    Category = "Electronics",
                    Price = 30000,
                    DiscountPercentage = 15
                },

                new Product
                {
                    ProductID = 3,
                    ProductName = "Shoes",
                    Category = "Fashion",
                    Price = 5000,
                    DiscountPercentage = 20
                }
            };


            // Func to calculate discount amount
            Func<Product, double> calculateDiscount =
                product => product.Price * product.DiscountPercentage / 100;


            // Func to calculate final price
            Func<Product, double> calculateFinalPrice =
                product => product.Price - calculateDiscount(product);


            // Action to display complete product details
            Action<Product> displayProduct = product =>
            {
                double discountAmount = calculateDiscount(product);
                double finalPrice = calculateFinalPrice(product);

                Console.WriteLine("----------------------------------------");

                Console.WriteLine($"Product ID          : {product.ProductID}");
                Console.WriteLine($"Product Name        : {product.ProductName}");
                Console.WriteLine($"Category            : {product.Category}");
                Console.WriteLine($"Price               : Rs. {product.Price}");
                Console.WriteLine($"Discount Percentage : {product.DiscountPercentage}%");
                Console.WriteLine($"Discount Amount     : Rs. {discountAmount}");
                Console.WriteLine($"Final Price         : Rs. {finalPrice}");
            };


            foreach (Product product in products)
            {
                displayProduct(product);
            }

            Console.WriteLine("----------------------------------------");
        }
    }
}