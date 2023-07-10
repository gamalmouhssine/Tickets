using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickets.Data;

namespace Tickets.Controllers
{
    public class ProducerController : Controller
    {
        private readonly Appdbcontext _appdbcontext;

        public ProducerController(Appdbcontext appdbcontext)
        {
            _appdbcontext = appdbcontext;
        }

        public async Task<IActionResult> Index()
        {
            var selectproducer = await _appdbcontext.producers.ToListAsync();
            return View(selectproducer);
        }
    }
}
