using eBilety.Data;
using eBilety.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eBilety.Controllers
{
    public class MoviesController : Controller
    {
        private readonly AppDbContext _context;
        public MoviesController(AppDbContext context)
        {
            this._context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.Include(n => n.Cinema).ToListAsync();
            return View(allMovies);
        }
    }
}
