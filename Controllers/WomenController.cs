using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using osu.golf.handicap.Models;

namespace osu.golf.handicap.Controllers
{
    public class WomenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result(Women womenScore)
        {
            womenScore.courseRating = 74.3;
            womenScore.slopeRating = 135;
            womenScore.scoreAvg=(womenScore.score1+womenScore.score2+womenScore.score3
            +womenScore.score4+womenScore.score5)/5;
            womenScore.handicap=(womenScore.scoreAvg-womenScore.courseRating)*113/womenScore.slopeRating;
            womenScore.handicap = Math.Round(womenScore.handicap,0);
            return View(womenScore);
        }
        public IActionResult White()
        {
            return View();
        }
    }
}