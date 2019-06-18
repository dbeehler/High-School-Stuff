using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            string again;
            do
            {
                int choice, secret;
                Random rand = new Random();

                Console.WriteLine("Pick 1 for Rock, 2 for Paper, 3 for Scissors");
                choice = Convert.ToInt32(Console.ReadLine());
                secret = rand.Next(1, 3);

                if (choice == secret)
                {
                    Console.WriteLine("You tied!");
                }
                else if (choice == 1 && secret == 3)
                {
                    Console.WriteLine("You win!");
                    score++;
                }
                else if (choice == 2 && secret == 1)
                {
                    Console.WriteLine("You win!");
                    score++;
                }
                else if (choice == 3 && secret == 2)
                {
                    Console.WriteLine("You win!");
                    score++;
                }
                else
                {
                    Console.WriteLine("You lose!");
                }

                Console.WriteLine("Your score is: " + score);
                Console.WriteLine("Play again?");

                again = Console.ReadLine();
            } while (again != "no");
        }
    }
}
