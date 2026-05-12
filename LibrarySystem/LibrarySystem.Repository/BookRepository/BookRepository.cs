using LibrarySystem.Repository.Data;
using LibrarySystem.Repository.Models;

namespace LibrarySystem.Repository.BookRepository
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Book> GetBookList()
        {
            var bookList = _context.Books.ToList();
            return bookList;
        }
    }
}
