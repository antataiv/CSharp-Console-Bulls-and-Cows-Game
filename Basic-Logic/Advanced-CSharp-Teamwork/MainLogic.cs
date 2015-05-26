using System;
using System.Linq;

namespace Advanced_CSharp_Teamwork
{
    class MainLogic
    {
        private static bool gameWon = false;
        private static int numberOfTries = 0;
        private static int[] number;
        private static int difficulty;
        private static int digits = 0;
        private static int difficultyChoice;
        public static void MainGameLogic()
        {
            Console.Write("Enter number of digits to play with (3-6): ");
            while (!int.TryParse(Console.ReadLine(), out digits) || digits<3 || digits>6)
            {
                Console.WriteLine("Try again. Use numbers between 3 and 6");
            }
            Console.Clear();

            Console.WriteLine(@"1. Difficulty level ""Easy"" (10 tries.)");
            Console.WriteLine(@"2. Difficulty level ""Medium"" (5 tries.)");
            Console.WriteLine(@"3. Difficulty level ""Hard"" (3 tries.)");
            Console.WriteLine("Choose difficulty level: 1, 2 or 3 ? ");
            Console.Write("Please make you choice:");
            
            while (!int.TryParse(Console.ReadLine(), out difficultyChoice) || (difficultyChoice < 1 || difficultyChoice > 3))
            {
                Console.Clear();
                Console.WriteLine(@"1. Difficulty level ""Easy"" (10 tries.)");
                Console.WriteLine(@"2. Difficulty level ""Medium"" (5 tries.)");
                Console.WriteLine(@"3. Difficulty level ""Hard"" (3 tries.)");
                Console.WriteLine("Choose difficulty level: 1, 2 or 3 ? ");
                Console.Write("Please make you choice:");
            }

            switch (difficultyChoice)
            {
                case 1:
                    difficulty = 10;
                    break;
                case 2:
                    difficulty = 5;
                    break;
                case 3:
                    difficulty = 3;
                    break;
            }

            Console.WriteLine("The number is: " + string.Join("", GenerateNumber(digits)));

            while (difficulty > 0 && !gameWon)
            {
                Console.Write("Enter your guess: ");
                string guess = Console.ReadLine();
                CheckTry(number, guess, digits);
                numberOfTries++;
                difficulty--;
            }

            if (gameWon)
            {
                gameWon = false;
               
                EndGame.YouWin();
            }
            else
            {
               
                EndGame.YouLose();
            }
        }

        private static int[] GenerateNumber(int countOfDigits)
        {
            number = new int[countOfDigits];
            Random rand = new Random();
            int currNum = 0, prevNum = 0;
            for (currNum = 0; currNum < countOfDigits; currNum++)
            {
                number[currNum] = rand.Next(0, 10);
                if (currNum > 0)
                {
                    for (prevNum = currNum - 1; prevNum >= 0; prevNum--)
                    {
                        if (number[currNum] == number[prevNum])
                        {
                            number[currNum] = rand.Next(0, 9);
                            prevNum = currNum;
                        }
                    }
                }
            }
            return number;
        }

        private static void CheckTry(int[] number, string guess, int digits)
        {
            int check;
            while (!int.TryParse(guess, out check)||guess.Length!=digits)
            {
                Console.WriteLine("Try agan please !!!");
                guess = Console.ReadLine();

            }
            int bulls = 0;
            int cows = 0;
            for (int i = 0; i < digits; i++)
            {
                int currDigit = (int)Char.GetNumericValue(guess[i]);
                if (number.Contains(currDigit))
                {
                    for (int j = 0; j < digits; j++)
                    {
                        if (currDigit == number[j] && i == j)
                        {
                            bulls++;
                        }
                        else if (currDigit == number[j] && i != j)
                        {
                            cows++;
                        }
                    }
                }
            }
            if (bulls == digits)
            {
                gameWon = true;
            }
            else
            {
                Console.WriteLine("{0} bulls and {1} cows", bulls, cows);
            }
        }
    }
}