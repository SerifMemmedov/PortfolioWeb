using Microsoft.AspNetCore.Mvc;
using PortfolioWeb.Models;
using PortfolioWeb.ViewModels;
using System.Diagnostics;

namespace PortfolioWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly PortfolioDbContext _context;  // homecontroller sql den data send and use


        public HomeController(ILogger<HomeController> logger, PortfolioDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {

            HomeVm vm = new()
            {

                MySection = _context.section1s.FirstOrDefault()

            };

            return View(vm);
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