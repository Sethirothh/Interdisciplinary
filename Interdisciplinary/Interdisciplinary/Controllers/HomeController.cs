using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Interdisciplinary.Models;
using Interdisciplinary.Data;
using Microsoft.EntityFrameworkCore;

namespace Interdisciplinary.Controllers
{
    public class HomeController : Controller
    {
        private readonly InterdisciplinaryContext _context;

        public HomeController(InterdisciplinaryContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var interdisciplinaryContext = _context.Foods.Include(f => f.Category).Include(f => f.User);
            return View(await interdisciplinaryContext.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
