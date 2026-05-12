using LibrarySystem.Business.BookBusiness;
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

        public IActionResult Index()
        {
            var bookList = _bookBusiness.GetBookList();
            return View(bookList);
        }

        public IActionResult AddBook()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult AddBook(BookDetails book)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        if (book.Name != "hello")
        //        {
        //            ModelState.AddModelError("Name","Hello custom error");
        //        }
               
        //        return View(book);
        //    }
        //    else
        //    {
        //        return View(book);
        //    }
            
        //}
    }
}
