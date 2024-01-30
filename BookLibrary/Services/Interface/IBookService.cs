using BookLibrary.Models.Entities;

namespace BookLibrary.Services.Interface
{
    public interface IBookService
    {
        Task AddBook(Book entity);
        Task UpdateBook(Book entity);
        Task DeleteBook(Book entity);
        Task<Book?> GetBook(string BookId);
        Task<IEnumerable<Book>> GetNewReleasedBooks();
        Task<IEnumerable<Book>> GetBooks();
    }
}
