using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Data.Services;
using Tickets.Models;

namespace Tickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducer _appdbcontext;

        public ProducerController(IProducer appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public async Task<IActionResult> Index()
        {  var allproducers = await _appdbcontext.GetAll();
            return View(allproducers);
        }
        //Get
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Producer producer)
        {
            _appdbcontext.Add(producer);
            return View();
        }
        //Get
        public async Task<IActionResult> Details(int id)
        {
            var Detail = await _appdbcontext.Getbyid(id);
            return View(Detail);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var Detail = await _appdbcontext.Getbyid(id);
            return View(Detail);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)
        {
            await _appdbcontext.Update(id, producer);
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
            await _appdbcontext.Remove(id);
            return RedirectToAction("Index");
        }
    }
}
