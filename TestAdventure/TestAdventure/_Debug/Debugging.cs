using System;
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
            Console.ReadKey();
        }
    }
}
