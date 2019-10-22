using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class VəzifəController : Controller
    {
        private readonly Db_Evimiz _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public VəzifəController(Db_Evimiz context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        public IActionResult Siyahı()
        {
            IEnumerable<IdentityRole> pstn = _roleManager.Roles.ToList();
            return View(pstn);
        }

        public IActionResult Yarat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Yarat(IdentityRole identityRole)
        {
            if (identityRole.Name == null)
            {
                ModelState.AddModelError("Name", "Boşluğu doldurun");
            }
            else
            {
                if(! await _roleManager.RoleExistsAsync(identityRole.Name))
                {
                    await _roleManager.CreateAsync(new IdentityRole(identityRole.Name));
                }
                else
                {
                    ModelState.AddModelError("Name", "Hal hazırda bu vəzifə movcuddur");
                }
            }

            return RedirectToAction("Siyahı","Vəzifə");
        }
    }
}