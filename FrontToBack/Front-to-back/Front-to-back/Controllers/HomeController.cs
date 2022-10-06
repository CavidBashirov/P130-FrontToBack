using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderImage sliderImage = await _context.SliderImages.FirstOrDefaultAsync();
            IEnumerable<Work> works = await _context.Works.Skip(3).Take(6).ToListAsync();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                SliderImage = sliderImage,
                Works = works
            };
            return View(model);
        }
    }
}
