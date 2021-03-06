﻿using System;
using System.Threading;

namespace Advanced_CSharp_Teamwork
{
    class EndGame
    {
        public static void YouWin()
        {
            Console.CursorVisible = false;
            //Console.SetWindowSize(103, 30);
            Console.WriteLine(@"
        ______   ______   .__   __.   _______ .______          ___   .___________.    _______.         
       /      | /  __  \  |  \ |  |  /  _____||   _  \        /   \  |           |   /       |         
      |  ,----'|  |  |  | |   \|  | |  |  __  |  |_)  |      /  ^  \ `---|  |----`  |   (----`         
      |  |     |  |  |  | |  . `  | |  | |_ | |      /      /  /_\  \    |  |        \   \             
      |  `----.|  `--'  | |  |\   | |  |__| | |  |\  \----./  _____  \   |  |    .----)   |            
       \______| \______/  |__| \__|  \______| | _| `._____/__/     \__\  |__|    |_______/             
                                                                                                       
            ____    ____  ______    __    __     ____    __    ____  __  .__   __.  __                 
            \   \  /   / /  __  \  |  |  |  |    \   \  /  \  /   / |  | |  \ |  | |  |                
             \   \/   / |  |  |  | |  |  |  |     \   \/    \/   /  |  | |   \|  | |  |                
              \_    _/  |  |  |  | |  |  |  |      \            /   |  | |  . `  | |  |                
                |  |    |  `--'  | |  `--'  |       \    /\    /    |  | |  |\   | |__|                
                |__|     \______/   \______/         \__/  \__/     |__| |__| \__| (__)             ");

            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(@"                                                                                           
.___________..______     ____    ____         ___       _______      ___       __  .__   __.  ______   
|           ||   _  \    \   \  /   /        /   \     /  _____|    /   \     |  | |  \ |  | |      \  
`---|  |----`|  |_)  |    \   \/   /        /  ^  \   |  |  __     /  ^  \    |  | |   \|  | `----)  | 
    |  |     |      /      \_    _/        /  /_\  \  |  | |_ |   /  /_\  \   |  | |  . `  |     /  /  
    |  |     |  |\  \----.   |  |         /  _____  \ |  |__| |  /  _____  \  |  | |  |\   |    |__|   
    |__|     | _| `._____|   |__|        /__/     \__\ \______| /__/     \__\ |__| |__| \__|     __    
                                                                                                (__)   
                                _______    ____  ___.__   __. ___                                      
                               /  /\   \  /   / /  /|  \ |  | \  \                                     
                              |  |  \   \/   / /  / |   \|  |  |  |                                    
                              |  |   \_    _/ /  /  |  . `  |  |  |                                    
                              |  |     |  |  /  /   |  |\   |  |  |                                    
                              |  |     |__| /__/    |__| \__|  |  |                                    
                               \__\                           /__/                                     ");
            TryAgain();
        }

        public static void YouLose()
        {
            Console.CursorVisible = false;
            //Console.SetWindowSize(103, 30);
            Console.WriteLine(@"
                       _______.  ______   .______      .______     ____    ____                        
                      /       | /  __  \  |   _  \     |   _  \    \   \  /   /                        
                     |   (----`|  |  |  | |  |_)  |    |  |_)  |    \   \/   /                         
                      \   \    |  |  |  | |      /     |      /      \_    _/                          
                  .----)   |   |  `--'  | |  |\  \----.|  |\  \----.   |  |                            
                  |_______/     \______/  | _| `._____|| _| `._____|   |__|                            
                                                                                                       
      ____    ____  ______    __    __      __        ______        _______. _______  __               
      \   \  /   / /  __  \  |  |  |  |    |  |      /  __  \      /       ||   ____||  |              
       \   \/   / |  |  |  | |  |  |  |    |  |     |  |  |  |    |   (----`|  |__   |  |              
        \_    _/  |  |  |  | |  |  |  |    |  |     |  |  |  |     \   \    |   __|  |  |              
          |  |    |  `--'  | |  `--'  |    |  `----.|  `--'  | .----)   |   |  |____ |__|              
          |__|     \______/   \______/     |_______| \______/  |_______/    |_______|(__)              ");

            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine(@"  
.___________..______     ____    ____         ___       _______      ___       __  .__   __.  ______   
|           ||   _  \    \   \  /   /        /   \     /  _____|    /   \     |  | |  \ |  | |      \  
`---|  |----`|  |_)  |    \   \/   /        /  ^  \   |  |  __     /  ^  \    |  | |   \|  | `----)  | 
    |  |     |      /      \_    _/        /  /_\  \  |  | |_ |   /  /_\  \   |  | |  . `  |     /  /  
    |  |     |  |\  \----.   |  |         /  _____  \ |  |__| |  /  _____  \  |  | |  |\   |    |__|   
    |__|     | _| `._____|   |__|        /__/     \__\ \______| /__/     \__\ |__| |__| \__|     __    
                                                                                                (__)   
                                _______    ____  ___.__   __. ___                                      
                               /  /\   \  /   / /  /|  \ |  | \  \                                     
                              |  |  \   \/   / /  / |   \|  |  |  |                                    
                              |  |   \_    _/ /  /  |  . `  |  |  |                                    
                              |  |     |  |  /  /   |  |\   |  |  |                                    
                              |  |     |__| /__/    |__| \__|  |  |                                    
                               \__\                           /__/                                     ");
            TryAgain();
        }

        private static void TryAgain()
        {
            //Console.Write("Would you like to try again(Y/N)?");
            string tryAgain = Console.ReadLine();
            if (tryAgain.ToLower() == "y")
            {
                Console.Clear();
                MainLogic.MainGameLogic();
            }
            else
            {
                Console.WriteLine("Thank you for playing. Bye Bye!!!");
            }
        }
    }
}
