using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Verandas;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class VerandaController : Controller
    {
        private readonly IVerandaManager _manager;
        public static Guid _restaurantForId;

        public VerandaController(IVerandaManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowVerandas()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateVerandas(Guid id)
        {
            _restaurantForId = id;
            Console.WriteLine(_restaurantForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateVerandaRequest request)
        {
            request.RestaurantForId = _restaurantForId;
            Console.WriteLine(request.RestaurantForId);
            await _manager.AddVeranda(request);
            return RedirectToAction(nameof(ShowVerandas));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateVerandas(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid VerandaId, CreateOrUpdateVerandaRequest request)
        {
            await _manager.UpdateVeranda(VerandaId, request);
            return RedirectToAction(nameof(ShowVerandas));
        }

        public async Task<ActionResult> DeleteVeranda(Guid id)
        {
            var entity = await _manager.DeleteVeranda(id);
            return RedirectToAction(nameof(ShowVerandas));
        }


    }
}