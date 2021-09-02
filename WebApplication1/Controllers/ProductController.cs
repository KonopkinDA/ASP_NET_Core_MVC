using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Products;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductManager _manager;
        public static Guid _foodForId;

        public ProductController(IProductManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowProducts()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateProducts(Guid id)
        {
            _foodForId = id;
            Console.WriteLine(_foodForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateProductRequest request)
        {
            request.FoodForId = _foodForId;
            Console.WriteLine(request.FoodForId);
            await _manager.AddProduct(request);
            return RedirectToAction(nameof(ShowProducts));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateProducts(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid ProductId, CreateOrUpdateProductRequest request)
        {
            await _manager.UpdateProduct(ProductId, request);
            return RedirectToAction(nameof(ShowProducts));
        }

        public async Task<ActionResult> DeleteProduct(Guid id)
        {
            var entity = await _manager.DeleteProduct(id);
            return RedirectToAction(nameof(ShowProducts));
        }


    }
}