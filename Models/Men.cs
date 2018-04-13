using System;

namespace osu.golf.handicap.Models
{
    public class Men
    {
        public string courseName{get; set;}
        public int score1{get; set;}
        public int score2{get; set;}
        public int score3{get; set;}
        public int score4{get; set;}
        public int score5{get; set;}
        public double scoreAvg{get; set;}
        public double courseRating{get; set;}
        public double slopeRating{get; set;}
        public double handicap{get; set;}
    }
}