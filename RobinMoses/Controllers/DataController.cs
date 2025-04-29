using RobinMoses.Data;
using RobinMoses.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace RobinMoses.Controllers
{
    public class DataController : Controller
    {
        IWebSiteRepo repository;
        WebDbContext context;
        private List<string> cartItems;
        private readonly ILogger<HomeController> _logger;
      
        public DataController(IWebSiteRepo m)
        {
            repository = m;
        }
        public IActionResult Index()
        {
            return View(cartItems);
        }


        [HttpPost]
        public IActionResult AddToCart(string itemName)
        {
            cartItems.Add(itemName);
            return RedirectToAction("Index");
        }
        
    public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
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