using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{
    class Program
    {
        static void Main()
        {
            String debug = "";
            Console.WriteLine("Enter 1, 2, 3, or 4");
            debug = Console.ReadLine();
            if (debug == "1")
                debugOne();
            else if (debug == "2")
                debugTwo();
            else if (debug == "3")
                debugThree();
            else if (debug == "4")
                debugFour();
        }
        static void debugOne()
        {
            string[] items = { "Belt", "Tie", "Scarf", "Cufflinks" };
            double[] prices = { 29.00, 35.95, 18.50, 112.99 };
            Console.WriteLine("Items for sale:");
            for (int x = 0; x < prices.Length; x++)
            {
                Console.WriteLine("{0,12} for {1, 10}", items[x], prices[x].ToString("C"));
            }
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }

        static void debugTwo()
        {
            int[] numbers = { 12, 15, 22, 88 };
            int x;
            double average;
            double total = 0;
            Console.Write("\nThe numbers are...");
            for (x = 0; x < numbers.Length; x++)
                Console.Write("{0, 6}", numbers[x]);
            Console.WriteLine();
            for (x = 0; x < numbers.Length; x++)
            {
                total += numbers[x];
            }
            average = total / numbers.Length;
            Console.WriteLine("The average is {0}", average);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }

        static void debugThree()
        {
            String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
            int x;
            string entryString;
            Console.Write("What book are you looking for? ");
            entryString = Console.ReadLine();
            x = Array.BinarySearch(books, entryString);
            if (x < 0)
                Console.WriteLine("{0} not found", entryString);
            else
                Console.WriteLine("Yes, we carry {0}", entryString);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }

        static void debugFour()
        {
            const int QUIT = 999;
            int[] numbers = new int[4];
            int x = 0;
            int num = 0;
            double average;
            double total = 0;
            string inString;
            Console.Write("Please enter a number or " + QUIT + " to quit...");
            inString = Console.ReadLine();
            num = Convert.ToInt32(inString);
            while((x < numbers.Length) && num != QUIT)
            {
 	            numbers[x] = num;
                total += numbers[x];
                x++;
                Console.Write("Please enter a number or " + QUIT + " to quit...");
                inString = Console.ReadLine();
                num = Convert.ToInt32(inString);
            }
            Console.WriteLine("The numbers are:");
            for(int y = 0; y < x; ++y)
                Console.Write("{0,6}", numbers[y]);
            average = total / x;
            Console.WriteLine();
            Console.WriteLine("The average is {0}", average);
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadLine();
        }
    }
}
