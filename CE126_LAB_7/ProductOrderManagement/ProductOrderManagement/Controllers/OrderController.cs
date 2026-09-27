using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProductOrderManagement.Models;

namespace ProductOrderManagement.Controllers
{
    public class OrderController : Controller
    {
        private static readonly List<Product> products = new()
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 55000
            },

            new Product
            {
                Id = 2,
                Name = "Mobile Phone",
                Price = 25000
            },

            new Product
            {
                Id = 3,
                Name = "Headphones",
                Price = 2500
            },

            new Product
            {
                Id = 4,
                Name = "Keyboard",
                Price = 1500
            }
        };


        [HttpGet]
        public IActionResult Create()
        {
            LoadProducts();

            return View();
        }


        [HttpPost]
        public IActionResult Create(OrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadProducts();

                return View(model);
            }

            var selectedProduct =
                products.FirstOrDefault(p => p.Id == model.ProductId);

            if (selectedProduct == null)
            {
                ModelState.AddModelError(
                    "ProductId",
                    "Please select a valid product.");

                LoadProducts();

                return View(model);
            }

            decimal totalAmount =
                selectedProduct.Price * model.Quantity;

            ViewBag.ProductName = selectedProduct.Name;
            ViewBag.Price = selectedProduct.Price;
            ViewBag.TotalAmount = totalAmount;

            return View("Success", model);
        }


        private void LoadProducts()
        {
            ViewBag.Products = new SelectList(
                products,
                "Id",
                "Name");
        }
    }
}