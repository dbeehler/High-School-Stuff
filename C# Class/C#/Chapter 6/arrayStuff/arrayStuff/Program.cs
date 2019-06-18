using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayStuff
{
    class Program
    {
        public static int[] numbers = new int [5] { 1, 2, 3, 4, 5 };
        public static Boolean running;
        public static int choice, average;

        static void Main(string[] args)
        {
            running = true;
            do
            {
                Array.Sort(numbers);
                Console.WriteLine("");
                Console.WriteLine("Enter 1 to list array");
                Console.WriteLine("Enter 2 to list array backwards");
                Console.WriteLine("Enter 3 to list the average of the array");
                Console.WriteLine("Enter 4 to end application");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (choice == 1)
                {
                    listArray();
                }
                else if (choice == 2)
                {
                    listArrayReverse();
                }
                else if (choice == 3)
                {
                    averageArray();
                }
                else if (choice == 4)
                {
                    Environment.Exit(0);
                }
            } while (running);
        }

        static void listArray()
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            }
        }

        static void listArrayReverse()
        {
            Array.Reverse(numbers);
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.WriteLine(numbers[x]);
            } 
        }

        static void averageArray()
        {
            int total = 0;
            for (int x = 0; x < numbers.Length; x++)
            {
                total += numbers[x];
                average = total / numbers.Length;
            }
            Console.WriteLine(total);
            Console.WriteLine("The average is " + average);
        }
    }
}
