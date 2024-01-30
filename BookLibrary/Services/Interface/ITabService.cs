using BookLibrary.Models.Entities;

namespace BookLibrary.Services.Interface
{
    public interface ITabService
    {
        Task<IEnumerable<SubCategory>> GetAll();
    }
}
