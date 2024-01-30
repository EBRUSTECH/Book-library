using BookLibrary.Data.Repository.Interfaces;
using BookLibrary.Models.Entities;
using BookLibrary.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Services.Implementation
{
    public class TabService : ITabService
    {
        private readonly IRepository _repository;
        public TabService(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SubCategory>> GetAll()
        {
            return (await _repository.GetAsync<SubCategory>())
                .Include(x => x.Book)
                .Include(x => x.Category)
                .AsEnumerable();
        }
    }
}
