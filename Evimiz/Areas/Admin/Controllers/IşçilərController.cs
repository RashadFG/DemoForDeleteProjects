using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Evimiz.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class IşçilərController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly RoleManager<IdentityRole> _rolemManager;
        private readonly UserManager<ApplicationUser> _userManager;
        public IşçilərController(Db_Evimiz context, RoleManager<IdentityRole> rolemManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _rolemManager = rolemManager;
            _userManager = userManager;
        }

        public IActionResult RoleSiyahı()
        {
            var users = new List<ApplicationUser>();
            if (!User.IsInRole("Istifadəçi") && !User.IsInRole("Əmlakçı") && !User.IsInRole("Admin"))
            {
                users = _context.Users.ToList();
            }
            return View(users);
        }

        public IActionResult Yarat()
        {
            ViewBag.NumberKeyCodes = _context.NumberKeyCodes.ToList();
            ViewBag.Roles = _rolemManager.Roles.ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Yarat(AdminEmployeeViewModel adminEmployeeViewModel)
        {
           
            ViewBag.Roles = _rolemManager.Roles.ToList();

            if (!ModelState.IsValid)
            {
                ViewBag.Employees = "Employees";
                ViewBag.Roles = _rolemManager.Roles.ToList();

                return View(adminEmployeeViewModel);
            }

            ApplicationUser customUser = new ApplicationUser
            {
                Firstname = adminEmployeeViewModel.Username,
                Lastname = adminEmployeeViewModel.Username,
                UserName = adminEmployeeViewModel.Username,
                Email = adminEmployeeViewModel.Email,
                NumberKeyCodeId = 1,
                EmailConfirmed = true,
            };

            IdentityResult result = await _userManager.CreateAsync(customUser, adminEmployeeViewModel.Password);

            if (!result.Succeeded)
            {
                ViewBag.Employees = "Employees";
                ViewBag.Roles = _rolemManager.Roles.ToList();

                ModelState.AddModelError("", "Bu istifadəçi artıq qeydiyyatdan keçib və ya şifrə tələblərə uyğun deyil.");

                return View(adminEmployeeViewModel);
            }

            IdentityRole identityRole = await _rolemManager.FindByIdAsync(adminEmployeeViewModel.RoleId);
            await _userManager.AddToRoleAsync(customUser, identityRole.Name);

            return RedirectToAction("RoleSiyahı", "Işçilər","Admin");
        }
    }
}