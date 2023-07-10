using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Data.Services;

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
    }
}
