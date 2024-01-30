using BookLibrary.Data.Repository.Interfaces;
using BookLibrary.Models.Entities;
using BookLibrary.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Services.Implementation
{
    public class BookService : IBookService
    {
        private readonly IRepository _repository;
        public BookService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task AddBook(Book entity)
        {
            await _repository.AddAsync(entity);
        }

        public async Task DeleteBook(Book entity)
        {
            await _repository.DeleteAsync(entity);
        }

        public async Task<Book?> GetBook(string BookId)
        {
            return await _repository.GetAsync<Book>(BookId);
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            return (await _repository.GetAsync<Book>())
                .Include(x => x.SubCategory).ThenInclude(x => x.Category)
                .Include(x => x.Reviews)
                .Include(x => x.Ratings)
                .Include(x => x.BookVersions);
        }
        public async Task<IEnumerable<Book>> GetNewReleasedBooks()
        {
            var allBooks = await GetBooks();
            return (allBooks.Where(b => (b.UpdateOn.Day - 7) < DateTime.Now.AddDays(1).Day));
        }

        public async Task UpdateBook(Book entity)
        {
            await _repository.UpdateAsync(entity);
        }
    }
}
