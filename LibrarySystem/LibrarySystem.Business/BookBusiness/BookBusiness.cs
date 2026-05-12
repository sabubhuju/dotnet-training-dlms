using LibrarySystem.Repository.BookRepository;
using LibrarySystem.Shared.BookData;

namespace LibrarySystem.Business.BookBusiness
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookRepository _bookRepository;

        public BookBusiness(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookDetails> GetBookList()
        {
            List<BookDetails> bookList = new List<BookDetails>();
            var books = _bookRepository.GetBookList();
            foreach (var book in books)
            {
                bookList.Add(new BookDetails
                {
                    Name = book.Name,
                    Author = book.Author,
                    Publication = book.Publication
                });
            }

            //var bookDetail = books.Select(x => new BookDetails
            //{
            //    Name = x.Name,
            //    Author = x.Author,
            //    Publication = x.Publication
            //}).ToList();

            return bookList;
        }
    }
}
