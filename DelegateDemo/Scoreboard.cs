using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    class Scoreboard
    {
        public static int CalculateAdultScore(int seconds, int targets)
        {
            return (targets * 10) - (seconds * 2);
        }

        public static int CalculateChildScore(int seconds, int targets)
        {
            return (targets * 15) - seconds;
        }

        public void TargetHit()
        {
            Console.WriteLine("Target Hit!");
        }

        public void PointsAwarded()
        {
            Console.WriteLine("Points awarded");
        }
    }
}
