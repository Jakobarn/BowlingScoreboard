using System;

namespace BowlingScoreboard
{
    public class ConsoleDisplay : IDisplay
    {
        public void showScore(int score)
        {
            Console.WriteLine("Your score is: " + score);
        }

        public void showWelcomeMessage()
        {
            Console.WriteLine("+-------------------------------------------+");
            Console.WriteLine("| Welcome to the ultimate bowling scorecard |");
            Console.WriteLine("+-------------------------------------------+");
        }
    }
}