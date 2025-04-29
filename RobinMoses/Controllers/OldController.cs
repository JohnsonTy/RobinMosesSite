using RobinMoses.Data;
using RobinMoses.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RobinMoses.Controllers
{
    public class LegacyController : Controller
    {
        IWebSiteRepo repository;
        WebDbContext context;
        public LegacyController(IWebSiteRepo m)
        {
            repository = m;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Authorize]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(menuItem);
            }
        }

        public IActionResult AddDrink()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Collections(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("NailArt");
            }
            else
            {
                return View(menuItem);
            }
        }

        [Authorize]
        public async Task<IActionResult> DeleteMenuItem(int itemId)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }


        [Authorize]
        public async Task<IActionResult> EditMenuItem(int itemId)
        {
            var g = repository;


            return View(g);
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditMenuItem(MenuItem menuItem)
        {

            return RedirectToAction("Index");
        }


        public IActionResult Specials()
        {
            var specItem = repository.GetSpecItem();
            return View(specItem);
        }

        public int GetCharacterCount(string itemName, double itemPrice)
        {
            int priceAsStringLength = itemPrice.ToString().Length; //   Nachos = 6  // 12.95 = 4  stringLength = 10
            int itemNameLength = itemName.Length;
            return itemNameLength + priceAsStringLength;
        }
    }
}
