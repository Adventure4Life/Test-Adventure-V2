using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class UserInput
    {
        //Public Variables
        private static string rawInput;
        private static List<string> cleanedInputTokens;
        private static List<string> stemmedInputTokens;

        #region Get-ers
        public static string GetRawInput()
        { return rawInput; }

        public static List<string> GetCleanedInputTokens()
        { return cleanedInputTokens; }

        public static List<string> GetStemmedInputTokens()
        { return stemmedInputTokens; }
        #endregion


        public static void GetInput(string input)
        {
            rawInput = input;
            cleanedInputTokens = TextUtils.TokenizeStringList(rawInput);
            stemmedInputTokens = TextUtils.StemWordList(cleanedInputTokens.ToList());
        }
    }
}
