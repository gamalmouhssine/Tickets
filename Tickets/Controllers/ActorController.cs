using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Data.Services;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActor _appdbcontext;

        public ActorController(IActor appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var allactors = await _appdbcontext.GetActors();
            return View(allactors);
        }
        //Get
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Actor actor)
        {
            _appdbcontext.AddActor(actor);
            return View();
        }
        //Get
        public async Task<IActionResult> Details(int id)
        {
            var Detail=await _appdbcontext.Getbyid(id);
            return View(Detail);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var Detail = await _appdbcontext.Getbyid(id);
            return View(Detail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,Actor actor)
        {
            await _appdbcontext.UpdateActor(id, actor);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            var Detail = await _appdbcontext.Getbyid(id);
            return View(Detail);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Deleteconfermed(int id)
        {
            await _appdbcontext.RemoveActor(id);
            return RedirectToAction("Index");
        }

    }
}
