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
            var menuItem = repository.GetMenuItem();
            return View(menuItem);
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
                await repository.AddMenuItem(menuItem);
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
        public async Task<IActionResult> AddDrink(MenuItem menuItem)
        {
            if (ModelState.IsValid)
            {
                await repository.AddMenuItem(menuItem);
                return RedirectToAction("DrinkMenu");
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
                await repository.DeleteMenuItem(itemId);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        [Authorize]
        public async Task<IActionResult> DeleteMenuDrinkItem(int itemId)
        {
            try
            {
                await repository.DeleteMenuItem(itemId);
                return RedirectToAction("DrinkMenu");
            }
            catch
            {
                return RedirectToAction("DrinkMenu");
            }
        }


        [Authorize]
        public async Task<IActionResult> EditMenuItem(int itemId)
        {
            var g = await repository.GetMenuItemByIdAsync(itemId);


            return View(g);
        }



        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditMenuItem(MenuItem menuItem)
        {

            await repository.UpdateMenu(menuItem);

            return RedirectToAction("Index");
        }

        [Authorize]
        public async Task<IActionResult> EditMenuDrinkItem(int itemId)
        {
            var g = await repository.GetMenuItemByIdAsync(itemId);


            return View(g);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> EditMenuDrinkItem(MenuItem menuItem)
        {

            await repository.UpdateMenu(menuItem);

            return RedirectToAction("DrinkMenu");
        }


        public IActionResult DrinkMenu()
        {

            var menuItem = repository.GetMenuItem();
            return View(menuItem);
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
