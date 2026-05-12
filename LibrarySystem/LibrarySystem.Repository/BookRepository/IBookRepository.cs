using LibrarySystem.Repository.Models;

namespace LibrarySystem.Repository.BookRepository
{
    public interface IBookRepository
    {
        Task<bool> AddBook(Book book);
        Task<Book> GetBookDetails(int id);
        Task<List<Book>> GetBookList();
    }
}
