using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace osu.golf.handicap.Controllers
{
    public class MenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Buckeye()
        {
            return View();
        }

        public IActionResult Black()
        {
            return View();
        }

        public IActionResult Scarlet()
        {
            return View();
        }

        public IActionResult Gray()
        {
            return View();
        }

        public IActionResult White()
        {
            return View();
        }
    }
}