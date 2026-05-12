using LibrarySystem.Repository.Models;

namespace LibrarySystem.Repository.BookRepository
{
    public interface IBookRepository
    {
        List<Book> GetBookList();
    }
}
