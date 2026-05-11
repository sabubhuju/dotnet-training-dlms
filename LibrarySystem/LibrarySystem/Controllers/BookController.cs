using LibrarySystem.Data;
using LibrarySystem.Dtos;
using LibrarySystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibrarySystem.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var bookList = _context.Books.ToList();
            return View(bookList);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBook(BookDetails book)
        {
            if(ModelState.IsValid)
            {
                if (book.Name != "hello")
                {
                    ModelState.AddModelError(string.Empty,"Hello custom error");
                }
               
                return View(book);
            }
            else
            {
                return View(book);
            }
            
        }
    }
}
