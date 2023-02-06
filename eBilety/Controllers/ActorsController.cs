using eBilety.Data;
using eBilety.Models;
using Microsoft.AspNetCore.Mvc;

namespace eBilety.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;
        public ActorsController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            List<Actor> data = _context.Actors.ToList();
            return View(data);
        }
    }
}
