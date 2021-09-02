using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Countrys;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class CountryController : Controller
    {
        private readonly ICountryManager _manager;

        public CountryController(ICountryManager manager)
        {
            _manager = manager;
        }

        [HttpGet]

        public async Task<ViewResult> ShowCountrys()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateCountry()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateCountryRequest request)
        {
            await _manager.AddCountry(request);
            return RedirectToAction(nameof(ShowCountrys));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateCountry(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid CountryId, CreateOrUpdateCountryRequest request)
        {
            await _manager.UpdateCountry(CountryId, request);
            return RedirectToAction(nameof(ShowCountrys));
        }

        public async Task<ActionResult> DeleteCountry(Guid id)
        {
            var entity = await _manager.DeleteCountry(id);
            return RedirectToAction(nameof(ShowCountrys));
        }

    }
}