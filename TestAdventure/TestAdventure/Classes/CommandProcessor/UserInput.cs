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
    }
}
