using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.Models;

namespace OnlineBookStore.Controllers
{
    public class BooksController : Controller
    {
        private static readonly List<Book> books = new()
        {
            new Book
            {
                Id = 1,
                Title = "C# Programming",
                Author = "John Smith",
                Category = "Programming",
                Price = 450,
                Description = "A beginner-friendly guide to C# programming."
            },

            new Book
            {
                Id = 2,
                Title = "ASP.NET Core MVC",
                Author = "Robert Brown",
                Category = "Programming",
                Price = 550,
                Description = "Learn how to build web applications using ASP.NET Core MVC."
            },

            new Book
            {
                Id = 3,
                Title = "The Great Adventure",
                Author = "David Wilson",
                Category = "Fiction",
                Price = 300,
                Description = "An exciting fictional adventure story."
            },

            new Book
            {
                Id = 4,
                Title = "Database Fundamentals",
                Author = "Michael Lee",
                Category = "Database",
                Price = 500,
                Description = "Introduction to database concepts and SQL."
            }
        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}