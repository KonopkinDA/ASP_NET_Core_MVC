using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Citys;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityManager _manager;
        public static Guid _countryForId;

        public CityController(ICityManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowCitys()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateCitys(Guid id)
        {
            _countryForId = id;
            Console.WriteLine(_countryForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateCityRequest request)
        {
            request.CountryForId = _countryForId;
            Console.WriteLine(request.CountryForId);
            await _manager.AddCity(request);
            return RedirectToAction(nameof(ShowCitys));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateCitys(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid CityId, CreateOrUpdateCityRequest request)
        {
            await _manager.UpdateCity(CityId, request);
            return RedirectToAction(nameof(ShowCitys));
        }

        public async Task<ActionResult> DeleteCity(Guid id)
        {
            var entity = await _manager.DeleteCity(id);
            return RedirectToAction(nameof(ShowCitys));
        }

        public  ViewResult FindCitys()
        {
            return View();
        }

        public async Task<ViewResult> FindN(FindCityRequest request)
        {
            var entity = await _manager.FindN(request.Name);

            return View(entity);
        }

        public async Task<ViewResult> FindP(FindCityRequest request)
        {
            var entity = await _manager.FindP(request.People);

            return View(entity);
        }

    }
}