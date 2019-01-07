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

        public static List<string> TokenizeStringList (string input)
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
            return cleanedInputList;
        }

        public static string CleanedWord(string word)
        {
            var banList = "~`!@#$%^&*()_+{}|[]\\:;\",<.>/?".ToCharArray();
            return string.Join("", word.Where(s => !banList.Contains(s)));
        }

        public static List<string> StemWordList (List<string> wordlist)
        {
            for (int i = 0; i < wordlist.Count; i++)
            {
                string StemValue = StemWord.Stem(wordlist[i]).Value;
                wordlist[i] = StemValue;
            }
            return wordlist;
        }
    }
}

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