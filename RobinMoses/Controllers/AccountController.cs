using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using RobinMoses.Models;

namespace RobinMoses.Controllers
{

        public class AccountController : Controller
        {
            private UserManager<AppUser> userManager;
            private SignInManager<AppUser> signInManager;
            public AccountController(UserManager<AppUser> userMngr, SignInManager<AppUser> signInMngr)
            {
                userManager = userMngr;
                this.signInManager = signInMngr;
            }

            [HttpGet]
            public IActionResult Index(string returnURL = "")
            {
                var model = new LoginVM { ReturnUrl = returnURL };
                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> Index(LoginVM model)
            {
                
                  
                    var result = await signInManager.PasswordSignInAsync(
                        model.Username, model.Password, isPersistent: model.RememberMe,
                        lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(model.ReturnUrl) &&
                            Url.IsLocalUrl(model.ReturnUrl))
                        {
                            return Redirect(model.ReturnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
       
                    
                }
      
                ModelState.AddModelError("", "Invalid username/password.");
                return View(model);
            }

            [HttpPost]
            public async Task<IActionResult> LogOut()
            {
                await signInManager.SignOutAsync();
                return RedirectToAction("Index", "Home");
            }

            public ViewResult AccessDenied()
            {
                return View();
            }
        }
    }
