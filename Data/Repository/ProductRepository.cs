using Data.Context;
using Data.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.Repository
{
    public class ProductRepository : IProductRepo
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {   
            _context = context;
        }

        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await _context.Products
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Product?> GetIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product is not null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> GetTotalCountAsync()
        {
            var products = await GetAllAsync();
            return 10;
        }
    }
}