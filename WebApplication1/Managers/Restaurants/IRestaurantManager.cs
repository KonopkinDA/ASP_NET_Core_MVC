using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Restaurants
{
    public interface IRestaurantManager
    {
        Task<Restaurant> AddRestaurant(CreateOrUpdateRestaurantRequest request);
        Task<Restaurant> UpdateRestaurant(Guid id, CreateOrUpdateRestaurantRequest request);
        Task<Restaurant> GetById(Guid id);
        Task<Restaurant> DeleteRestaurant(Guid id);
        Task<IReadOnlyCollection<Restaurant>> GetAll();


        Task<IReadOnlyCollection<Restaurant>> FindN(string name);

        Task<IReadOnlyCollection<Restaurant>> FindS(int stars);
    }
}
