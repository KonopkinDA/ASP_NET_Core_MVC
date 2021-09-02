using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Verandas
{
    public class VerandaManager : IVerandaManager
    {
        private readonly ProductDataContext _dbContext;

        public VerandaManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Veranda> AddVeranda(CreateOrUpdateVerandaRequest request)
        {
            var entity = new Veranda
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                YearTime = request.YearTime,
                RestaurantForId = request.RestaurantForId
            };

            _dbContext.Verandas.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task <Veranda> UpdateVeranda(Guid id, CreateOrUpdateVerandaRequest request)
        {
            var entity = await _dbContext.Verandas.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.YearTime = request.YearTime;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Veranda> GetById(Guid id)
        {
            return await _dbContext.Verandas.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Veranda> DeleteVeranda(Guid id)
        {
            var entity = await _dbContext.Verandas.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Verandas.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Veranda>> GetAll()
        {
            var query = _dbContext.Verandas.Include(g => g.RestaurantFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }
    }
}

