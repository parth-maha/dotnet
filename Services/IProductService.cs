using Data.Entities;

namespace Services
{
    public interface IProductService
    {
        Task<IReadOnlyList<Product>> GetAllAsync();
        Task<Product?> GetIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<int> GetTotalCountAsync();
    }
}