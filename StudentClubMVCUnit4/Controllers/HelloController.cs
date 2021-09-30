using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentClubMVCUnit4.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello World!");
            return View("Index");
            
        }

        public IActionResult MN()
        {
            return View("MN");
        }

        public IActionResult WI()
        {
            return View("WI");
        }
    }
}
