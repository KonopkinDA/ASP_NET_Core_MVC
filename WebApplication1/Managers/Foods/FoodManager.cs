using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Foods
{
    public class FoodManager : IFoodManager
    {
        private readonly ProductDataContext _dbContext;

        public FoodManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Food> AddFood(CreateOrUpdateFoodRequest request)
        {
            var entity = new Food
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Price= request.Price,
                MenuForId = request.MenuForId
            };

            _dbContext.Foods.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Food> UpdateFood(Guid id, CreateOrUpdateFoodRequest request)
        {
            var entity = await _dbContext.Foods.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.Price = request.Price;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Food> GetById(Guid id)
        {
            return await _dbContext.Foods.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Food> DeleteFood(Guid id)
        {
            var entity = await _dbContext.Foods.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Foods.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Food>> GetAll()
        {
            var query = _dbContext.Foods.Include(g => g.MenuFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }
    }
}
