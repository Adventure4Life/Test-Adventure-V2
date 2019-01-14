using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class UserInput
    {
        //Public Variables
        private static string rawInput;
        private static string[] cleanedInputTokens;
        private static string[] stemmedInputTokens;

        #region Get-ers
        public static string GetRawInput()
        { return rawInput; }

        public static string[] GetCleanedInputTokens()
        { return cleanedInputTokens; }

        public static string[] GetStemmedInputTokens()
        { return stemmedInputTokens; }
        #endregion


        public static void GetInput(string input)
        {
            rawInput = Regex.Replace(input, @"\s+", " "); //make sure there is only 1 white space between each word.
            cleanedInputTokens = TextUtils.TokenizeStringList(rawInput);
            stemmedInputTokens = TextUtils.StemWordList(cleanedInputTokens);
        }

        public static void AnyKeyContinue()
        {
            Console.CursorVisible = false;
            //Console.Write("                                                    Press Any-Key to Continue");
            Console.Write("\n\n");
            Pause_AnyKey();
            Console.CursorVisible = true;
        }
        #region Pause for AnyKey / Clear Input Buffer
        /// <summary>
        /// Wait for user input before continuing.
        /// </summary>
        public static void Pause_AnyKey()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable); // when a key is pressed it breaks the loop
            ClearInput();
        }
        /// <summary>
        /// Clear the user input buffer.
        /// </summary>
        public static void ClearInput()
        {   //Loop through any inputs in the input buffer and "spend them" doing nothing.
            while (Console.KeyAvailable) { Console.ReadKey(true); }
        }
        #endregion
    }
}
