using Mapster;
using Mapsterr.Models;

using Mapsterr.Models.VMs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mapsterr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult Libraries()
        {
            // Örnek veriler
            var libraries = new List<Library>
            {
            new Library
            {
                Id = 1,
                Name = "City Library",
                Books = new List<Book>
                {
                    new Book { Id = 1 , Title = "1984", AuthorName = "George Orwell" },
                    new Book { Id = 2, Title = "To Kill a Mockingbird", AuthorName = "Harper Lee" }
                }
            }
            };

            // Mapster ile dönüþtürme
            var libraryVMs = libraries.Adapt<List<LibraryVM>>();

            return View(libraryVMs);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
