using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hawkeyeChallenge2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for ladder, 2 for cipher, 3 for RPS, 4 for Image Compression, and 5 for twoSum");
            int picker = Convert.ToInt32(Console.ReadLine());
            if (picker == 1)
                tallestLadder();
            else if (picker == 2)
                cipher();
            else if (picker == 3)
                RPS();
            else if (picker == 4)
                imageComp();
            else if (picker == 5)
                twoSum();
            else
                Environment.Exit(0);
        }

        static void tallestLadder()
        {
            int tallestLadder = 0;
            int ladderCount = 0;
            int input = 0;

            Console.WriteLine("How many ladders are there");
            ladderCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ladderCount);
            int[] allNumbers = new int[ladderCount];

            do{
                for (int i = 0; i < ladderCount; i++)
                {
                    Console.WriteLine("Enter a ladder height");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (input > tallestLadder)
                        tallestLadder = input;
                    allNumbers[i] = input;
                }
            }while (allNumbers.Length < ladderCount);

            Console.WriteLine("Here are all the ladders values");
            for (int x = 0; x < allNumbers.Length; x++)
            {
                Array.Sort(allNumbers);
                Console.WriteLine(allNumbers[x]);
            }
            Console.WriteLine("Tallest ladder was: " + tallestLadder);
            Console.ReadLine();
        }


        /*
         * This right here?
         * I have no idea how whis worked, but it did...
         * No rewriting required 
         */
     
        static void cipher()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string code;
            int currentChar, charInAlphabet = 0;
            alphabet.ToCharArray();

            Console.WriteLine("Enter your code!");
            code = Console.ReadLine();
            code.ToLower();
            code.ToCharArray();

            char[] newCode = code.ToCharArray();

            for (int a = 0; a < code.Length; a++)
            {
                currentChar = code[a];
                for (int b = 0; b < alphabet.Length; b++)
                {
                    if (currentChar == 'z'){
                        charInAlphabet = -1;
                        break;
                    }
                    else if (currentChar == 'y')
                    {
                        charInAlphabet = -2;
                        break;
                    }
                    else if (currentChar == 'x'){
                        charInAlphabet = -3;
                        break;
                    }
                    else if (currentChar == alphabet[b])
                    {
                        charInAlphabet = alphabet.IndexOf(alphabet[b]);
                        break;
                    }
                }
                newCode[a] = alphabet[charInAlphabet + 3];
            }
            Console.Write("new code: ");
            for (int x = 0; x < newCode.Length; x++)
            {
                Console.Write(newCode[x]);
            }
            Console.ReadLine();
        }

        static void RPS()
        {
            char firstChoice, secondChoice;
            Console.WriteLine("Welcome to Rock, Paper, Scissors");
            Console.WriteLine("Type your first Choice R, P, or S");
            firstChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Type your second Choice R, P, or S");
            secondChoice = Convert.ToChar(Console.ReadLine());

            //bad if statements
            if (firstChoice == 'R' && secondChoice == 'S')
                Console.WriteLine("Rock Wins!");
            else if (firstChoice == 'P' && secondChoice == 'R')
                Console.WriteLine("Paper Wins!");
            else if (firstChoice == 'S' && secondChoice == 'P')
                Console.WriteLine("Scissors Win");
            else if (secondChoice == 'R' && firstChoice == 'S')
                Console.WriteLine("Rock Wins!");
            else if (secondChoice == 'P' && firstChoice == 'R')
                Console.WriteLine("Paper Wins!");
            else if (secondChoice == 'S' && firstChoice == 'P')
                Console.WriteLine("Scissors Win");
            else
                Console.WriteLine("Tie");
            Console.ReadLine();
        }

        static void imageComp()
        {
            String colorRow;
            int numberB = 0, numberS = 0, numberY = 0;
            Console.WriteLine("Enter a String of colors");
            colorRow = Console.ReadLine();

            colorRow.ToCharArray();

            for (int i = 0; i < colorRow.Length; i++)
            {
                if (colorRow[i] == 'B')
                    numberB++;
                else if (colorRow[i] == 'S')
                    numberS++;
                else if (colorRow[i] == 'Y')
                    numberY++;
            }
            Console.WriteLine(numberB + "B" + numberS + "S" + numberY + "Y");
            Console.ReadLine();
        }

        //this also is blowing me away on how well it worked without rewriting it
        static void twoSum()
        {
            int amountNum, currentNumber;
            bool sumZero = false;
            Console.WriteLine("Enter how many numbers there are");
            amountNum = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[amountNum];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                currentNumber = numbers[i];
                for (int x = 0; x < numbers.Length; x++)
                {
                    if (currentNumber + numbers[x] == 0)
                    {
                        sumZero = true;
                    }
                }
            }
            if (sumZero)
                Console.WriteLine(sumZero);
            else
                Console.WriteLine(sumZero);
            Console.ReadLine();
        }
    }
}
