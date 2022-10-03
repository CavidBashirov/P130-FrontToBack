using Front_to_back.Models;
using Microsoft.AspNetCore.Mvc;
namespace Front_to_back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Car car = new Car
            {
                Id = 1,
                Name = "BMW"
            };
            return View(car);
        }
    }
}
