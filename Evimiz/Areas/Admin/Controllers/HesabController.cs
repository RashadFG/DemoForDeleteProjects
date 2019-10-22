using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HesabController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public HesabController(UserManager<ApplicationUser> userManager,
                              SignInManager<ApplicationUser> signInManager,
                              RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public async Task<IActionResult> AdminLogIn()
        {
            if (!await _roleManager.RoleExistsAsync("İstifadəçi"))
            {
                await _roleManager.CreateAsync(new IdentityRole("İstifadəçi"));
            }

            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            ApplicationUser userAdminExists = await _userManager.FindByNameAsync("Admin");

            if (userAdminExists == null)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    Firstname = "admin",
                    Lastname = "admin",
                    Email = "insinekuliziader@gmail.com",
                    EmailConfirmed = true,
                    UserName = "admin",
                    NumberKeyCodeId = 1,
                    NumberKeyCodeSecondId = 1,
                    PhoneNumber = "9876543",
                    SecondPhonenumber = "9876543",
                    Agencyabout = "",
                    RegionId = 1,
                    RegisterDate = DateTime.Now,
                };

                await _userManager.CreateAsync(user, "Admin1234@");
                await _userManager.AddToRoleAsync(user, "Admin");
            }

            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AdminLogIn(LoginViewModelAdmin loginViewModelAdmin)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModelAdmin);
            }

            ApplicationUser user = await _userManager.FindByEmailAsync(loginViewModelAdmin.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Bu adlı istifadəçi yoxdur");
                return View(loginViewModelAdmin);
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, loginViewModelAdmin.Password, true, true);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Şifrə və ya Email düzgün deyil");
                return View(loginViewModelAdmin);
            }

            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public async  Task<IActionResult> AdminLogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Dashboard");
        }

    }
}