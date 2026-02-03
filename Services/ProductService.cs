using Data.Context;
using Data.Entities;
using Data.Repository;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public Task<IReadOnlyList<Product>> GetAllAsync() => _productRepo.GetAllAsync();

        public Task<Product?> GetIdAsync(int id) => _productRepo.GetIdAsync(id);

        public async Task AddAsync(Product product)
        {
            ValidateProduct(product);
            await _productRepo.AddAsync(product);
        } 

        public async Task UpdateAsync(Product product)
        {
            ValidateProduct(product);
            await _productRepo.UpdateAsync(product);
        }

        public Task DeleteAsync(int id) => _productRepo.DeleteAsync(id);

        public Task<int> GetTotalCountAsync() => _productRepo.GetTotalCountAsync();
         private static void ValidateProduct(Product product)
        {
            if(product.Price<=0)
                throw new ArgumentException("Price must be positive");
        }
    }
}