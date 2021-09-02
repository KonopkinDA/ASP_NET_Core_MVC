using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Managers.Products
{
    public interface IProductManager
    {
        Task<Product> AddProduct(CreateOrUpdateProductRequest request);
        Task<IReadOnlyCollection<Product>> GetAll();
        Task<Product> UpdateProduct(Guid id, CreateOrUpdateProductRequest request);
        Task<Product> GetById(Guid id);
        Task<Product> DeleteProduct(Guid id);
    }
}