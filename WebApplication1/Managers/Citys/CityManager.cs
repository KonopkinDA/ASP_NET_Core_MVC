using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Citys
{
    public class CityManager : ICityManager
    {
        private readonly ProductDataContext _dbContext;

        public CityManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<City> AddCity(CreateOrUpdateCityRequest request)
        {
            var entity = new City
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                People = request.People,
                CountryForId = request.CountryForId
            };

            _dbContext.Citys.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<City> UpdateCity(Guid id, CreateOrUpdateCityRequest request)
        {
            var entity = await _dbContext.Citys.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.People = request.People;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<City> GetById(Guid id)
        {
            return await _dbContext.Citys.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<City> DeleteCity(Guid id)
        {
            var entity = await _dbContext.Citys.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Citys.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<City>> GetAll()
        {
            var query = _dbContext.Citys.Include(g=>g.CountryFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }

        public async Task<IReadOnlyCollection<City>> FindN(string name)
        {
            var querry = await _dbContext.Citys.ToListAsync();
            List<City> querry2 = new List<City>();
            foreach(var item in querry)
            {
                if (item.Name == name)
                {
                    querry2.Add(item);
                }
            }

            return querry2;
        }

        public async Task<IReadOnlyCollection<City>> FindP(int people)
        {
            var querry = await _dbContext.Citys.ToListAsync();
            List<City> querry2 = new List<City>();
            foreach (var item in querry)
            {
                if (item.People == people)
                {
                    querry2.Add(item);
                }
            }

            return querry2;
        }
    }
}
