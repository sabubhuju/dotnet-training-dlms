using LibrarySystem.Business.BookBusiness;
using LibrarySystem.Shared.BookData;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookBusiness _bookBusiness;

        public BookController(IBookBusiness bookBusiness)
        {
            _bookBusiness = bookBusiness;
        }

        public async Task<IActionResult> Index()
        {
            var bookList = await _bookBusiness.GetBookList();
            return View(bookList);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBook(BookDetails book)
        {
            if (ModelState.IsValid)
            {
                //if (book.Name != "hello")
                //{
                //    ModelState.AddModelError("Name", "Hello custom error");
                //}
                bool isAdded = await _bookBusiness.AddBook(book);
                TempData["Message"] = isAdded ? "Book added successfully" : "Failed to add book";
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }


        public async Task<IActionResult> EditBook(string id)
        {
            var bookId = Convert.ToInt32(id);
            var bookDetails = await _bookBusiness.GetBookDetails(bookId);
            return View(bookDetails);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBook(BookDetails book)
        {
            if (ModelState.IsValid)
            {
                //bool isAdded = await _bookBusiness.AddBook(book);
                //TempData["Message"] = isAdded ? "Book added successfully" : "Failed to add book";
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
    }
}
