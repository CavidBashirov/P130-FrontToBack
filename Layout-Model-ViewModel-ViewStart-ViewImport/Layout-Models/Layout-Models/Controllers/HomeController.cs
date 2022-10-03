using Layout_Models.Models;
using Layout_Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layout_Models.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Book> books = new List<Book>();

            Car car = new Car
            {
                Id = 1,
                Name = "BMW",
                Color = "Black"
            };

            Book book1 = new Book
            {
                Id = 1,
                Name = "1 gozel",
                AuthorName = "Nizami",
                PublishDate = new DateTime(1500, 5, 1)
            };
            Book book2 = new Book
            {
                Id = 2,
                Name = "2 gozel",
                AuthorName = "Nizami",
                PublishDate = new DateTime(1500, 5, 1)
            };
            Book book3 = new Book
            {
                Id = 3,
                Name = "3 gozel",
                AuthorName = "Nizami",
                PublishDate = new DateTime(1500, 5, 1)
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);

            HomeVM model = new HomeVM
            {
                Books = books,
                Car = car
            };


            return View(model);
        }
   
    }
}
