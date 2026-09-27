using Microsoft.AspNetCore.Mvc;
using MVC_BookApp.Models;

namespace MVC_BookApp.Controllers
{
    public class BookController : Controller
    {
        
        static List<Book> books = new List<Book>()
        {
            new Book{
                BookId=1, 
                Title="C#", 
                Author="ABC", 
                Category="Programming", 
                Price=500, 
                PublishedYear=2020
            },
            new Book{
                BookId=2,
                Title="Java", 
                Author="XYZ", 
                Category="Programming", 
                Price=400, 
                PublishedYear=2019
            }
        };

        // VIEW ALL
        public IActionResult Index()
        {
            return View(books);
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            return View(book);
        }

        // CREATE GET
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Book b)
        {
            b.BookId = books.Count + 1;
            books.Add(b);
            return RedirectToAction("Index");
        }

        // EDIT GET
        public IActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            return View(book);
        }

        // EDIT POST
        [HttpPost]
        public IActionResult Edit(Book b)
        {
            var book = books.FirstOrDefault(x => x.BookId == b.BookId);
            book.Title = b.Title;
            book.Author = b.Author;
            book.Category = b.Category;
            book.Price = b.Price;
            book.PublishedYear = b.PublishedYear;

            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var book = books.FirstOrDefault(b => b.BookId == id);
            books.Remove(book);
            return RedirectToAction("Index");
        }
    }
}