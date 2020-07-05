using System;
using System.Runtime.CompilerServices;

namespace DelegateDemo
{
    class Program
    {
        delegate int CalculateScore(int seconds, int targets);
        delegate void ShowStatus();
        static void Main(string[] args)
        {
            Scoreboard board = new Scoreboard();

            ShowStatus points = new ShowStatus(board.PointsAwarded);
            ShowStatus hit = new ShowStatus(board.TargetHit);

            ShowStatus display = points;
            display += hit;

            CalculateScore getScore;
            int time = 60;
            int targets = 20;

            getScore = new CalculateScore(Scoreboard.CalculateAdultScore);
            Console.WriteLine("Adult score: {0}", getScore(time, targets));

            getScore = null;

            getScore = new CalculateScore(Scoreboard.CalculateChildScore);
            Console.WriteLine("Child score: {0}", getScore(time, targets));

            getScore = null;

            display();

            display -= hit;
            display = null;

            Console.ReadKey();
        }
    }
}
