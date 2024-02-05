using book_case_project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace book_case_project.Controllers
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

            var ktp = new List<Books>()
            {
                new Books(){ID = 1, BookName="Gör Beni", Writer="Azra Kohen"},
                new Books(){ID = 2, BookName="Oysa Herkes Kendisiyle Meşgul", Writer="Murat Gülsoy"},
                new Books(){ID = 3, BookName = "Asansör", Writer="Beyza Alkoç"},
                new Books(){ID = 4, BookName = "Hayallerime Dokun", Writer="Edith Wharton"},
                new Books(){ID = 5, BookName = "Allah'ın Güzel İsimleri", Writer="Özkan Öze"},
            };

            return View(ktp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}