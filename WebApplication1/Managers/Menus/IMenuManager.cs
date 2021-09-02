using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Menus
{
    public interface IMenuManager
    {
        Task<Menu> AddMenu(CreateOrUpdateMenuRequest request);
        Task<Menu> UpdateMenu(Guid id, CreateOrUpdateMenuRequest request);
        Task<Menu> GetById(Guid id);
        Task<Menu> DeleteMenu(Guid id);
        Task<IReadOnlyCollection<Menu>> GetAll();
    }
}
