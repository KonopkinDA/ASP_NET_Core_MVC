using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Menus
{
    public class MenuManager : IMenuManager
    {
        private readonly ProductDataContext _dbContext;

        public MenuManager(ProductDataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Menu> AddMenu(CreateOrUpdateMenuRequest request)
        {
            var entity = new Menu
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Size = request.Size,
                VerandaForId = request.VerandaForId
            };

            _dbContext.Menus.Add(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Menu> UpdateMenu(Guid id, CreateOrUpdateMenuRequest request)
        {
            var entity = await _dbContext.Menus.FirstOrDefaultAsync(g => g.Id == id);

            entity.Name = request.Name;
            entity.Size = request.Size;

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<Menu> GetById(Guid id)
        {
            return await _dbContext.Menus.FirstOrDefaultAsync(g => g.Id == id);
        }

        public async Task<Menu> DeleteMenu(Guid id)
        {
            var entity = await _dbContext.Menus.FirstOrDefaultAsync(g => g.Id == id);

            _dbContext.Menus.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyCollection<Menu>> GetAll()
        {
            var query = _dbContext.Menus.Include(g => g.VerandaFor).AsNoTracking();

            var entitys = await query.ToListAsync();

            return entitys;
        }
    }
}

