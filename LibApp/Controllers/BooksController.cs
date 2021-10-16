using Microsoft.AspNetCore.Mvc;
using LibApp.Models;

namespace LibApp.Controllers
{
    public class BooksController : Controller
    {
        private IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
        public IActionResult Random()
        {
            var firstBook = new Book() { Id = 1, Name = "English" };
            return View(firstBook);
        }
        public IActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}
