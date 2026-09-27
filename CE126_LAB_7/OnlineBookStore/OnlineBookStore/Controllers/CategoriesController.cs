using Microsoft.AspNetCore.Mvc;

namespace OnlineBookStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<string>
            {
                "Programming",
                "Fiction",
                "Database",
                "Science",
                "History"
            };

            return View(categories);
        }
    }
}