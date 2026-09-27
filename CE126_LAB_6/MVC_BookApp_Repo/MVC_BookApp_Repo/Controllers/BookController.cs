using Microsoft.AspNetCore.Mvc;
using MVC_BookApp_Repo.Models;

namespace MVC_BookApp_Repo.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository repo;

        public BookController(IBookRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(repo.GetById(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            repo.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            repo.Update(book);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(Book book)
        {
            repo.Delete(book.BookId);
            return RedirectToAction("Index");
        }
    }
}