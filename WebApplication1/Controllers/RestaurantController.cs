using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Restaurants;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantManager _manager;
        public static Guid _cityForId;

        public RestaurantController(IRestaurantManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowRestaurants()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateRestaurants(Guid id)
        {
            _cityForId = id;
            Console.WriteLine(_cityForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateRestaurantRequest request)
        {
            request.CityForId = _cityForId;
            Console.WriteLine(request.CityForId);
            await _manager.AddRestaurant(request);
            return RedirectToAction(nameof(ShowRestaurants));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateRestaurants(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid RestaurantId, CreateOrUpdateRestaurantRequest request)
        {
            await _manager.UpdateRestaurant(RestaurantId, request);
            return RedirectToAction(nameof(ShowRestaurants));
        }

        public async Task<ActionResult> DeleteRestaurant(Guid id)
        {
            var entity = await _manager.DeleteRestaurant(id);
            return RedirectToAction(nameof(ShowRestaurants));
        }

        public ViewResult FindRestaurants()
        {
            return View();
        }

        public async Task<ViewResult> FindN(FindRestaurantRequest request)
        {
            var entity = await _manager.FindN(request.Name);

            return View(entity);
        }

        public async Task<ViewResult> FindS(FindRestaurantRequest request)
        {
            var entity = await _manager.FindS(request.Stars);

            return View(entity);
        }
    }
}