using eBilety.Data;
using eBilety.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBilety.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context;
        public CinemasController(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Cinema> allCinemas = await _context.Cinemas.ToListAsync();
            return View();
        }
    }
}
