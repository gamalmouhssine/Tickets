using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets.Controllers
{
    public class CinemaController : Controller
    {
        private readonly Appdbcontext _appdbcontext;

        public CinemaController(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var selectcinema = await _appdbcontext.cinemas.ToListAsync();
            return View(selectcinema);
        }
    }
}
