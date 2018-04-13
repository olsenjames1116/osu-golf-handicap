using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using osu.golf.handicap.Models;

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
        public IActionResult BuckeyeResult(Men menScore)
        {
            menScore.courseRating = 76.2;
            menScore.slopeRating = 138;
            menScore.scoreAvg=(menScore.score1+menScore.score2+menScore.score3
            +menScore.score4+menScore.score5)/5;
            menScore.handicap=(menScore.scoreAvg-menScore.courseRating)*113/menScore.slopeRating;
            menScore.handicap = Math.Round(menScore.handicap,0);
            return View(menScore);
        }

        public IActionResult Black()
        {
            return View();
        }

        public IActionResult BlackResult(Men menScore)
        {
            menScore.courseRating = 74.3;
            menScore.slopeRating = 135;
            menScore.scoreAvg=(menScore.score1+menScore.score2+menScore.score3
            +menScore.score4+menScore.score5)/5;
            menScore.handicap=(menScore.scoreAvg-menScore.courseRating)*113/menScore.slopeRating;
            menScore.handicap = Math.Round(menScore.handicap,0);
            return View(menScore);
        }

        public IActionResult Scarlet()
        {
            return View();
        }
        public IActionResult ScarletResult(Men menScore)
        {
            menScore.courseRating = 72;
            menScore.slopeRating = 130;
            menScore.scoreAvg=(menScore.score1+menScore.score2+menScore.score3
            +menScore.score4+menScore.score5)/5;
            menScore.handicap=(menScore.scoreAvg-menScore.courseRating)*113/menScore.slopeRating;
            menScore.handicap = Math.Round(menScore.handicap,0);
            return View(menScore);
        }
        public IActionResult Gray()
        {
            return View();
        }
        public IActionResult GrayResult(Men menScore)
        {
            menScore.courseRating = 70.1;
            menScore.slopeRating = 128;
            menScore.scoreAvg=(menScore.score1+menScore.score2+menScore.score3
            +menScore.score4+menScore.score5)/5;
            menScore.handicap=(menScore.scoreAvg-menScore.courseRating)*113/menScore.slopeRating;
            menScore.handicap = Math.Round(menScore.handicap,0);
            return View(menScore);
        }
        public IActionResult White()
        {
            return View();
        }
        public IActionResult WhiteResult(Men menScore)
        {
            menScore.courseRating = 67.4;
            menScore.slopeRating = 123;
            menScore.scoreAvg=(menScore.score1+menScore.score2+menScore.score3
            +menScore.score4+menScore.score5)/5;
            menScore.handicap=(menScore.scoreAvg-menScore.courseRating)*113/menScore.slopeRating;
            menScore.handicap = Math.Round(menScore.handicap,0);
            return View(menScore);
        }
    }
}