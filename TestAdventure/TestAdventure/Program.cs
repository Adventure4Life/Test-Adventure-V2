﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine.Initilise();
            //Engine.StartScreen();

            while (GameState.GameHasNotEnded())
            {
                Engine.PlayGame();
                DeBugging.TestSomething();
            }

            // Debugging
            DeBugging.Exit();
        }
    }
}
