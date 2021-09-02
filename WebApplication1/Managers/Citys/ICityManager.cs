using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Citys
{
    public interface ICityManager
    {
        Task<City> AddCity(CreateOrUpdateCityRequest request);
        Task<City> UpdateCity(Guid id, CreateOrUpdateCityRequest request);
        Task<City> GetById(Guid id);
        Task<City> DeleteCity(Guid id);
        Task<IReadOnlyCollection<City>> GetAll();


        Task<IReadOnlyCollection<City>> FindN(string name);

        Task<IReadOnlyCollection<City>> FindP(int people);
    }
}
