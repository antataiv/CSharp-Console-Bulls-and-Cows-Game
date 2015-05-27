using System;

namespace Advanced_CSharp_Teamwork
{
    class Program
    {
        static void Main()
        {
            Console.Title = "BULLS AND COWS - by Team VOSS";
            Console.SetWindowSize(100, 30);
            StartGame.Start();

            var keyInput = Console.ReadKey(true);

            while ((keyInput.KeyChar != '1') && (keyInput.KeyChar != '2') && (keyInput.KeyChar != '3'))
            {
                Console.Clear();
                //Console.WriteLine("Invalid input. Please use only 1, 2 or 3.");
                //Console.Write("Please make you choice:");
                StartGame.ShowMenu();
                keyInput = Console.ReadKey(true);
            }
            Console.Clear();
            switch (keyInput.KeyChar)
            {
                case '1':
                    MainLogic.MainGameLogic();
                    break;
                case '2':
                    //show the help of the game
                    Console.WriteLine("Here we show the game instructions.");
                    keyInput = Console.ReadKey(true);
                    if (keyInput.KeyChar != ' ')
                    {
                        StartGame.ShowMenu();
                        keyInput = Console.ReadKey(true);
                    }
                    break;
                case '3':
                    Console.WriteLine("Thank you for playing. Bye bye!!!");
                    break;
            }
        }
    }
}