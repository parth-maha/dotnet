using Data.Entities;

namespace Data.Repository
{
    public interface IProductRepo
    {
        Task<IReadOnlyList<Product>> GetAllAsync();
        Task<Product?> GetIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<int> GetTotalCountAsync();
    }
}