//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using VertusNaurellesEcommerceV1.Models;
//using VertusNaurellesEcommerceV1.Models.ViewsModels;

//namespace VertusNaurellesEcommerceV1.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly UserManager<AppUser> userManager;
//        private readonly SignInManager<AppUser> signInManager;
//        public AccountController(UserManager<AppUser> _userManager,SignInManager<AppUser> _signInManager)
//        {
//            userManager = _userManager;
//            signInManager = _signInManager;


//        }

//        [HttpGet]
//        public IActionResult Register()
//        {
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> Register(AccountRegisterViewModel model)
//        {
//            if (ModelState.IsValid)
//            {
//                string FullName = GenerateUserName(model.FirstName, model.LastName);
//                AppUser user = new AppUser
//                {
//                    UserName = FullName,
//                    Email = model.Email,
//                    FirstName=model.FirstName,
//                    LastName =model.LastName,
//                    Address=model.Address,
//                    City=model.City,
//                    CodeZip=model.CodeZip,
//                    Country=model.Country
                    

//                };
                
//                //je cree un password a l'utilisateur 
//                var result = await userManager.CreateAsync(user, model.Password);
//                if (result.Succeeded)
//                {
//                    await signInManager.SignInAsync(user, isPersistent: false);
//                    return RedirectToAction("Index", "Account");
//                }
//                foreach (var error in result.Errors)
//                {
//                    ModelState.AddModelError("", error.Description);
//                }
//            }
//            return View(model);
//        }

//        private string GenerateUserName(string firstName,string LastName)
//        {
//            return firstName.Trim().ToUpper()+ "_" + LastName.Trim().ToLower();
//        }
//    }
//}
