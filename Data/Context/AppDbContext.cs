using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using Data.Entities;

namespace Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }
}