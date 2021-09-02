using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Foods
{
    public interface IFoodManager
    {
        Task<Food> AddFood(CreateOrUpdateFoodRequest request);
        Task<IReadOnlyCollection<Food>> GetAll();
        Task<Food> UpdateFood(Guid id, CreateOrUpdateFoodRequest request);
        Task<Food> GetById(Guid id);
        Task<Food> DeleteFood(Guid id);
    }
}
