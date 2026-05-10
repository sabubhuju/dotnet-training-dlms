
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PassValueFromController()
        {
            
            //var books = new List<Book>();
            //books.Add(new Book { 
            //    BookName = "The Great Gatsby", 
            //    BookAuthor = "F. Scott Fitzgerald", 
            //    BookType = "Novel", 
            //    BookYear = "1925" }
            //);

            var bookDetails = new List<Book>
            {
                new Book { Name = "To Kill a Mockingbird", Author = "Harper Lee", Category = "Novel", Year = "1960" },
                new Book { Name = "1984", Author = "George Orwell", Category = "Dystopian", Year = "1949" }
            };
            //return View(bookDetails);

            //ViewData
            var bookValue = new Book
            {
                Name = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                Category = "Novel",
                Year = "1925"
            };
            ViewData["BookDetails"] = bookValue;

            //ViewBag
            ViewBag.BookDetails = bookValue;

            TempData.Keep();
            return View(bookDetails);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
