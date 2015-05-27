using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
        private static List<string> currentProgress = new List<string>();
        private static int leftOffSet = (Console.WindowWidth / 2);
        private static int topOffSet = (Console.WindowHeight / 2);
        private static string guess = String.Empty;
        public static void MainGameLogic()
        {
            //Console.SetCursorPosition(leftOffSet - 30, topOffSet);
            Console.SetCursorPosition(leftOffSet - 30, 5);
            Console.Write("Enter number of digits to play with (3-6): ");
            while (!int.TryParse(Console.ReadLine(), out digits) || digits < 3 || digits > 6)
            {
                Console.Clear();
                //Console.SetCursorPosition(leftOffSet - 30, topOffSet);
                Console.SetCursorPosition(leftOffSet - 30, 5);
                Console.Write("Enter number of digits to play with (3-6): ");
            }
            Console.Clear();
            //Console.SetCursorPosition(leftOffSet, topOffSet - 5);
            Console.SetCursorPosition(leftOffSet, 5);
            Console.Write(@"
                                1. Difficulty level ""Easy"" (10 tries.)
                                2. Difficulty level ""Medium"" (5 tries.)
                                3. Difficulty level ""Hard"" (3 tries.)
                                Choose difficulty level: 1, 2 or 3 ? 
                                Please make you choice: ");

            while (!int.TryParse(Console.ReadLine(), out difficultyChoice) || (difficultyChoice < 1 || difficultyChoice > 3))
            {
                Console.Clear();
                //Console.SetCursorPosition(leftOffSet, topOffSet - 5);
                Console.SetCursorPosition(leftOffSet, 5);
                Console.Write(@"
                                1. Difficulty level ""Easy"" (10 tries.)
                                2. Difficulty level ""Medium"" (5 tries.)
                                3. Difficulty level ""Hard"" (3 tries.)
                                Choose difficulty level: 1, 2 or 3 ? 
                                Please make you choice: ");
            }
            Console.Clear();
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

            GenerateNumber(digits);
            currentProgress.Clear();
            currentProgress.Add(new string('*', 25));
            currentProgress.Add(string.Format("* The number is: {0}\t*", string.Join("", number)));
            currentProgress.Add(string.Format("* The number is: {0}\t*", new string('*', digits)));
            currentProgress.Add(new string('*', 25));

            while (difficulty > 0 && !gameWon)
            {
                Console.Clear();
                Console.SetCursorPosition(leftOffSet - 10, 2);
                ShowCurrentProgress();
                guess = GetUserGuess();
                CheckTry(number, guess, digits);
                numberOfTries++;
                difficulty--;
            }

            if (gameWon)
            {
                Console.Clear();
                gameWon = false;
                EndGame.YouWin();
            }
            else
            {
                Console.Clear();
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
            while (!int.TryParse(guess, out check) || guess.Length != digits || IsDigitDuplicated(guess))
            {
                Console.SetCursorPosition(leftOffSet - 45, 0);
                Console.WriteLine("Your number is with {0} digits and single digit cannot duplicated within a number!!!", digits);
                Console.SetCursorPosition(leftOffSet - 10, 1);
                Console.WriteLine("Try again please.");
                Thread.Sleep(2000);
                Console.Clear();
                ShowCurrentProgress();
                guess = GetUserGuess();
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
                currentProgress.Add(string.Format("* Your guess: {0}\t*", guess));
                currentProgress.Add(string.Format("* {0} bulls and {1} cows\t*", bulls, cows));
                currentProgress.Add(new string('*', 25));
                //Console.WriteLine("{0} bulls and {1} cows", bulls, cows);
            }
        }
        private static bool IsDigitDuplicated(string guess)
        {
            for (int currIndex = 1; currIndex < guess.Length; currIndex++)
            {
                for (int prevIndex = currIndex - 1; prevIndex >= 0; prevIndex--)
                {
                    if (guess[currIndex].Equals(guess[prevIndex]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void ShowCurrentProgress()
        {
            int topIndent = 5;
            foreach (var line in currentProgress)
            {
                Console.SetCursorPosition(leftOffSet - 10, topIndent);
                Console.WriteLine(line);
                topIndent++;
            }
        }

        private static string GetUserGuess()
        {
            guess = String.Empty;
            Console.SetCursorPosition(leftOffSet - 10, 4);
            Console.Write("Enter your guess: ");
            guess = Console.ReadLine();
            return guess;
        }
    }
}