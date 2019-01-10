using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class ReadDataFile
    {
        public static List<string> Read_DataFile(string path, string filename)
        {
            List<string> ReadData_rawAll = new List<string>();
            filename = filename + ".txt";
            string fullPath = Path.Combine(path, filename);

            foreach (string line in File.ReadLines(fullPath))
            {
                if (line != "")
                {
                    ReadData_rawAll.Add(line);
                }
            }
            return ReadData_rawAll;
        }

        public static string Read_SingleLine(string uniqueKeyword, List<string> fileData)
        {
            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(uniqueKeyword))
                {
                    string foundLine = cleanCatagorieTxT(fileData[i], uniqueKeyword);
                    return foundLine;
                }
            }
            return null;
        }

        public static string ReadData_LinesInsideBrackets(string uniqueKeyword, List<string> fileData, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (fileData[i].StartsWith(uniqueKeyword))
                {
                    string foundLine = cleanCatagorieTxT(fileData[i], uniqueKeyword);
                    return foundLine;
                }
            }
            return null;
        }
        

        private static string cleanCatagorieTxT(string line, string keyWord)
        {
            if (line.StartsWith(keyWord))
            {
                int s = keyWord.Length;
                int l = line.Length - keyWord.Length;
                line = line.Substring(s, l);
            }
            return line.Trim();
        }

        public static Dictionary<string, object> Read_BracketCount(string BracketStart_Key, string BracketEnd_Key, List<string> fileData)
        {
            Dictionary<string, object> BracketData = new Dictionary<string, object>();
            int bracketCount = 0;
            List<int> bracketIndex_Start = new List<int>();
            List<int> bracketIndex_End = new List<int>();

            for (int i = 0; i < fileData.Count; i++)
            {
                if (fileData[i].StartsWith(BracketStart_Key))
                {
                    bracketIndex_Start.Add(i);
                    bracketCount++;
                }
                if (fileData[i].StartsWith(BracketEnd_Key))
                {
                    bracketIndex_End.Add(i);
                }
            }

            BracketData.Add("count", bracketCount);
            BracketData.Add("startList", bracketIndex_Start);
            BracketData.Add("endList", bracketIndex_End);

            return BracketData;
        }
    }
}
/*
 * object[] BracketData = new object[2];

            List<string> testList = new List<string>();
            testList.Add("0: testing");
            testList.Add("1: testing");
            testList.Add("2: testing");
            BracketData[0] = 0;
            BracketData[1] = testList;

            List<string> wtf = BracketData[1] as List<string>;

            BracketData[0] = 1;
            List<string> wtf = BracketData[1];
*/