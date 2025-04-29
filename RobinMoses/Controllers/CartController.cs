using Microsoft.AspNetCore.Mvc;

namespace RobinMoses.Controllers
{
    public class CartController : Controller
    {
        private static List<string> cartItems = new List<string>();

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
    }
}
