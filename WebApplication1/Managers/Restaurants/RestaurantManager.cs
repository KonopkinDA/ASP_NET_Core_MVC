using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Restaurants
{
    public class RestaurantManager :IRestaurantManager
    {
        private readonly ProductDataContext _dbContext;

        public RestaurantManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Restaurant> AddRestaurant(CreateOrUpdateRestaurantRequest request)
        {
            var entity = new Restaurant
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Stars = request.Stars,
                CityForId = request.CityForId
            };

            _dbContext.Restaurants.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Restaurant> UpdateRestaurant(Guid id, CreateOrUpdateRestaurantRequest request)
        {
            var entity = await _dbContext.Restaurants.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.Stars = request.Stars;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Restaurant> GetById(Guid id)
        {
            return await _dbContext.Restaurants.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Restaurant> DeleteRestaurant(Guid id)
        {
            var entity = await _dbContext.Restaurants.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Restaurants.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Restaurant>> GetAll()
        {
            var query = _dbContext.Restaurants.Include(g => g.CityFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }

        public async Task<IReadOnlyCollection<Restaurant>> FindN(string name)
        {
            var querry = await _dbContext.Restaurants.ToListAsync();
            List<Restaurant> querry2 = new List<Restaurant>();
            foreach (var item in querry)
            {
                if (item.Name == name)
                {
                    querry2.Add(item);
                }
            }

            return querry2;
        }

        public async Task<IReadOnlyCollection<Restaurant>> FindS(int stars)
        {
            var querry = await _dbContext.Restaurants.ToListAsync();
            List<Restaurant> querry2 = new List<Restaurant>();
            foreach (var item in querry)
            {
                if (item.Stars == stars)
                {
                    querry2.Add(item);
                }
            }

            return querry2;
        }
    }
}

