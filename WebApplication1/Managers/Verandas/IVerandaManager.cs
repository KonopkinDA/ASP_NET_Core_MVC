using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Verandas
{
    public interface IVerandaManager
    {
        Task<Veranda> AddVeranda(CreateOrUpdateVerandaRequest request);
        Task<Veranda> UpdateVeranda(Guid id, CreateOrUpdateVerandaRequest request);
        Task<Veranda> GetById(Guid id);
        Task<Veranda> DeleteVeranda(Guid id);
        Task<IReadOnlyCollection<Veranda>> GetAll();
    }
}
