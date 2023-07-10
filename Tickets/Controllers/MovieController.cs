using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets.Controllers
{
    public class MovieController : Controller
    {
        private readonly Appdbcontext _appdbcontext;

        public MovieController(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }
        public async Task<IActionResult> Index()
        {
            var selectmovies = await _appdbcontext.movies.ToListAsync();
            return View(selectmovies);
        }
    }
}
