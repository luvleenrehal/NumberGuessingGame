using System;

namespace GuessingNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int numToWin = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess number between 0 - 100");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > numToWin)
                {
                    Console.WriteLine("Too High: Guess a lower number");
                }
                else if (i < numToWin)
                {
                    Console.WriteLine("Too Low: Guess a higher number");
                }
                else if (i == numToWin)
                {
                    Console.WriteLine("You Win!");
                    win = true;

                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing");
            Console.Write("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
