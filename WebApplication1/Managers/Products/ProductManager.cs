using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Products
{
    public class ProductManager : IProductManager
    {
        private readonly ProductDataContext _dbContext;

        public ProductManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Product> AddProduct(CreateOrUpdateProductRequest request)
        {
            var entity = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Time = request.Time,
                FoodForId = request.FoodForId
            };

            _dbContext.Products.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Product> UpdateProduct(Guid id, CreateOrUpdateProductRequest request)
        {
            var entity = await _dbContext.Products.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.Time = request.Time;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Product> GetById(Guid id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Product> DeleteProduct(Guid id)
        {
            var entity = await _dbContext.Products.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Products.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Product>> GetAll()
        {
            var query = _dbContext.Products.Include(g => g.FoodFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }
    }
}
