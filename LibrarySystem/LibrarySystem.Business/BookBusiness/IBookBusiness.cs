using LibrarySystem.Shared.BookData;

namespace LibrarySystem.Business.BookBusiness
{
    public interface IBookBusiness
    {
        List<BookDetails> GetBookList();
    }
}
