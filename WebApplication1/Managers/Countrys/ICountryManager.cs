using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Countrys
{
    public interface ICountryManager
    {
        Task<Country> AddCountry(CreateOrUpdateCountryRequest request);
        Task<Country> UpdateCountry(Guid id, CreateOrUpdateCountryRequest request);
        Task<Country> GetById(Guid id);
        Task<Country> DeleteCountry(Guid id);
        Task<IReadOnlyCollection<Country>> GetAll();
    }
}
