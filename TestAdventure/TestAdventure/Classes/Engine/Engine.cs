using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
     static class Engine
    {
        public static void Initilise()
        {
            Level.InitiliseLevel();
            Console.SetWindowSize(150, 40); // Default Size = 120 : 30
        }

        public static void StartScreen()
        {
            //TODO : Set a start Screen for the game initialization before main loop
            PrintBuffer.PrintFrame();
            PrintBuffer.PrintType();
            UserInput.AnyKeyContinue();
            PrintBuffer.PrintFrame();
        }

        public static void PlayGame()
        {
            AreaUtilities.ActivateArea(Player.GetCurrentArea());
            Console.Write("\n> ");
            UserInput.GetInput(Console.ReadLine());
        }

        private static void areaActivate()
        {
            //Player.GetCurrentArea().LookArea();
            //PrintBuffer.PrintScreen();
        }
    }
}
