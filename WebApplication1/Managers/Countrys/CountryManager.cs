using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Countrys
{
    public class CountryManager : ICountryManager
    {
        private readonly ProductDataContext _dbContext;

        public CountryManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Country> AddCountry(CreateOrUpdateCountryRequest request)
        {
            var entity = new Country
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Comment= request.Comment
            };

            _dbContext.Countrys.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Country> UpdateCountry(Guid id, CreateOrUpdateCountryRequest request)
        {
            var entity = await _dbContext.Countrys.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.Comment = request.Comment;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Country> GetById(Guid id)
        {
            return await _dbContext.Countrys.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Country> DeleteCountry(Guid id)
        {
            var entity = await _dbContext.Countrys.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Countrys.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Country>> GetAll()
        {
            var query = _dbContext.Countrys.AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }
    }
}
