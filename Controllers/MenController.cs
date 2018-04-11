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
            return Content("you reached men");
        }

        public IActionResult Buckeye()
        {
            return Content("you reached men's buckeye");
        }

        public IActionResult Black()
        {
            return Content("you reached men's black");
        }

        public IActionResult Scarlet()
        {
            return Content("you reached men's scarlet");
        }

        public IActionResult Gray()
        {
            return Content("you reached men's gray");
        }

        public IActionResult White()
        {
            return Content("you reached men's white");
        }
    }
}