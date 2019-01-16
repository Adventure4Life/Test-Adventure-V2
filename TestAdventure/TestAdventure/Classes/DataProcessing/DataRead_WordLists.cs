using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class DataRead_WordLists
    {
        private List<string> fileData;
        private string filePath = @"Data\commands\verbs\";

        public DataRead_WordLists(string type)
        {
            switch (type)
            {
                case "verbs":
                    filePath = @"Data\commands\verbs\";
                    break;
                case "nouns":
                    filePath = @"Data\commands\nouns\";
                    break;
            }
        }

        public void AddSafe(Dictionary<string, string> dictionary, string key, string value)
        {
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, value);
        }

        public void ProcessCommand(string fileName, Dictionary<string, string> CmdList)
        {
            fileData = new List<string>(ReadDataFile.Load_DataFile(filePath, fileName));

            string value = ReadDataFile.Read_RawSingleLine("//--Base_VERB:", fileData);
            int[] brackest = ReadDataFile.FindUniqueBrackets("//Synonyms-Start", "//Synonyms-END", fileData);
            List<string> keys = ReadDataFile.Read_WordLists(brackest[0], brackest[1], fileData);

            keys = TextUtils.StemWordList(keys);
            AddSafe(CmdList, value, value);
            foreach (string synonym in keys)
            {
                AddSafe(CmdList, synonym, value);
            }
        }

    }
}