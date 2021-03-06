﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class DeBugging
    {
        public static void TestSomething()
        {
            Console.WriteLine(CommandDictonary.GetCommandList().Count);
            foreach (KeyValuePair<string, string> item in CommandDictonary.GetCommandList())
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        public static void TestOriginalDataFiles()
        {
            Console.WriteLine(Level.Layout[0, 0].Name());
            Console.WriteLine(Level.Layout[0, 0].LookDescription());
            foreach (Exit exit in Level.Layout[0, 0].Exits())
            {
                Console.WriteLine("\n" + exit.name);
                Console.WriteLine(exit.open);
                if (exit.look_area_open != null) { Console.WriteLine(exit.look_area_open); }
                if (exit.look_area_closed != null) { Console.WriteLine(exit.look_area_closed); }
                if (exit.look_at_closed != null) { Console.WriteLine(exit.look_at_closed); }
                if (exit.look_at_open != null) { Console.WriteLine(exit.look_at_open); }
                if (exit.use_Closed != null) { Console.WriteLine(exit.use_Closed); }
                if (exit.use_Open != null) { Console.WriteLine(exit.use_Open); }
            }
            

            foreach (Items item in Level.Layout[0, 0].ItemList())
            {
                Console.WriteLine("\n"+item.name);
                Console.WriteLine(item.PickedupAllowed);
                Console.WriteLine(item.description_Default);
                Console.WriteLine(item.description_Dropped);
                Console.WriteLine(item.description_Gone);
                Console.WriteLine(item.getItem_Success);
                Console.WriteLine(item.getItem_NotAllowed);
            }
        }

        public static void Test_Tokenisation()
        {

            Console.WriteLine("\n: Raw Input : ");
            Console.WriteLine(UserInput.GetRawInput());
            Console.WriteLine("\nCleaned Tokens");

            foreach (string line in UserInput.GetCleanedInputTokens())
            {
                Console.WriteLine(line);
            }
            
            Console.WriteLine("\nStemmed Tokens");
            foreach (string line in UserInput.GetStemmedInputTokens())
            {
                Console.WriteLine(line);
            }
        }

        public static void Exit()
        {
            Console.CursorVisible = false;
            Console.WriteLine("\n*** Press Any Key to Exit ***");
            Console.ReadKey(true);
        }
    }
}
