using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using WebApplication1.Managers;
using WebApplication1.Managers.Menus;
using WebApplication1.Storage.Entity;

namespace WebApplication1.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuManager _manager;
        public static Guid _verandaForId;

        public MenuController(IMenuManager manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public async Task<ViewResult> ShowMenus()
        {
            var entity = await _manager.GetAll();

            return View(entity);
        }

        public async Task<ViewResult> CreateMenus(Guid id)
        {
            _verandaForId = id;
            Console.WriteLine(_verandaForId);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateMenuRequest request)
        {
            request.VerandaForId = _verandaForId;
            Console.WriteLine(request.VerandaForId);
            await _manager.AddMenu(request);
            return RedirectToAction(nameof(ShowMenus));
        }

        [HttpGet]
        public async Task<ViewResult> UpdateMenus(Guid id)
        {
            var entity = await _manager.GetById(id);

            return View(entity);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Guid MenuId, CreateOrUpdateMenuRequest request)
        {
            await _manager.UpdateMenu(MenuId, request);
            return RedirectToAction(nameof(ShowMenus));
        }

        public async Task<ActionResult> DeleteMenu(Guid id)
        {
            var entity = await _manager.DeleteMenu(id);
            return RedirectToAction(nameof(ShowMenus));
        }


    }
}