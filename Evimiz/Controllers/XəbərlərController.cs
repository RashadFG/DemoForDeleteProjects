using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Evimiz.DAL;
using Evimiz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Evimiz.Controllers
{
    public class XəbərlərController : Controller
    {
        private readonly Db_Evimiz _context;

        public XəbərlərController(Db_Evimiz context)
        {
            _context = context;
        }

        [ActionName("Haqqında")]
        public IActionResult About(int? id)
        {
            var oneNew = _context.Newss.FirstOrDefault(x => x.Id == id);
            oneNew.ViewCount = oneNew.ViewCount++;
            return View(oneNew);
        }
    }
}