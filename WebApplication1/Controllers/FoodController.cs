using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Foods;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodManager _manager;
        public static Guid _menuForId;

        public FoodController(IFoodManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowFoods()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateFoods(Guid id)
        {
            _menuForId = id;
            Console.WriteLine(_menuForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateFoodRequest request)
        {
            request.MenuForId = _menuForId;
            Console.WriteLine(request.MenuForId);
            await _manager.AddFood(request);
            return RedirectToAction(nameof(ShowFoods));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateFoods(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid FoodId, CreateOrUpdateFoodRequest request)
        {
            await _manager.UpdateFood(FoodId, request);
            return RedirectToAction(nameof(ShowFoods));
        }

        public async Task<ActionResult> DeleteFood(Guid id)
        {
            var entity = await _manager.DeleteFood(id);
            return RedirectToAction(nameof(ShowFoods));
        }


    }
}