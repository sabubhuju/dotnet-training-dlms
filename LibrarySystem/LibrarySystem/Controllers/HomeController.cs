
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            TempData["data"] = "I'm temprory data to used in subsequent request";
            return RedirectToAction("Privacy");
        }

        public IActionResult Privacy()
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
                new Book { BookName = "To Kill a Mockingbird", BookAuthor = "Harper Lee", BookType = "Novel", BookYear = "1960" },
                new Book { BookName = "1984", BookAuthor = "George Orwell", BookType = "Dystopian", BookYear = "1949" }
            };
            //return View(bookDetails);

            //ViewData
            var bookValue = new Book
            {
                BookName = "The Great Gatsby",
                BookAuthor = "F. Scott Fitzgerald",
                BookType = "Novel",
                BookYear = "1925"
            };
            ViewData["BookDetails"] = bookValue;

            //ViewBag
            ViewBag.BookDetails = bookValue;

            TempData.Keep();
            return View(bookDetails);
        }


        public IActionResult TestView()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    
}
