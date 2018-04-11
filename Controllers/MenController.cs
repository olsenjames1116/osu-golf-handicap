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
    }
}