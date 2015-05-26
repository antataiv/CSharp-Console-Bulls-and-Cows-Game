using System;

namespace Advanced_CSharp_Teamwork
{
    class Program
    {
        static void Main()
        {
            int choice;
            Console.SetWindowSize(100, 30);
            StartGame.Start();

            Console.Write("Please make you choice:");
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 3))
            {
                Console.WriteLine("Invalid input. Please use only 1, 2 or 3.");
                Console.Write("Please make you choice:");
            }

            switch (choice)
            {
                case 1:
                    MainLogic.MainGameLogic();
                    break;
                case 2:
                    //show the help of the game
                    break;
                case 3:
                    Console.WriteLine("Thank you for playing. Bye bye!!!");
                    break;
            }
        }
    }
}