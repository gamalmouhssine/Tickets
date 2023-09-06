using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;
using Tickets.Data.Services;

namespace Tickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovies _appdbcontext;

        public MovieController(IMovies appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var AllMovies = await _appdbcontext.GetAllAsync(c=>c.cinema);
            return View(AllMovies);
        }
    }
}
