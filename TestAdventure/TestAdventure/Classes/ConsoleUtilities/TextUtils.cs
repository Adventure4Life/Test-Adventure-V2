using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class TextUtils
    {
       static EnglishPorter2Stemmer StemWord = new EnglishPorter2Stemmer();

        #region Tokenisarion - CleanWord - Stemming
        public static string[] TokenizeStringList (string input)
        {
            List<string> cleanedInputList = new List<string>();
            string[] raw_cleanedInputString = input.ToLower().Trim().Split(null);

            foreach (string word in raw_cleanedInputString)
            {
                if (word != "")
                {
                    string s = CleanedWord(word);
                    if (s != "") cleanedInputList.Add(s);
                }
            }

            string[] copyList2String = new string[cleanedInputList.Count];
            cleanedInputList.CopyTo(copyList2String);
            return copyList2String;
        }

        public static string CleanedWord(string word)
        {
            var banList = "~`!@#$%^&*()_+{}|[]\\:;\",<.>/?".ToCharArray();
            return string.Join("", word.Where(s => !banList.Contains(s)));
        }

        public static string[] StemWordList (string[] wordlist)
        {
            //string[] copyArray = new string[wordlist.Length];
            //Array.Copy(wordlist, copyArray, wordlist.Length);
            string[] copyArray = wordlist.ToArray();
            for (int i = 0; i < copyArray.Length; i++)
            {
                string StemValue = StemWord.Stem(copyArray[i]).Value;
                copyArray[i] = StemValue;
            }
            return copyArray;
        }
    }
    #endregion

}

#region working and junk code
/*
        /* My Original Cleaning Method.. I replaced with with a smaller code from StackExchange
        public static string CleanedWord(string word)
        {
            char[] whiteList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789'".ToArray();
            char[] rawChars = word.ToArray();
            List<char> cleanedChars = new List<char>();
            for (int i = 0; i < rawChars.Length; i++)
            {
                foreach (char c in whiteList)
                {
                    if (rawChars[i] == c)
                    { cleanedChars.Add(c); }
                }
            }
            if (cleanedChars.Count == 0)
            { return ""; }
            else
            {
                char[] c = cleanedChars.ToArray();
                string s = new string(c);
                return s;
            }
        }*/
#endregion
