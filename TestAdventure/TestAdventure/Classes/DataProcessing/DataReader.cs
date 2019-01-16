using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class DataReader
    {
        public Area ImportAreaData(string filename)
        {
            DataRead_Area AreaPhraser = new DataRead_Area(filename);
            Area newArea = AreaPhraser.GetArea();
            return newArea;
        }

        public void ImportCommandData(string type, string filename, Dictionary<string, string> CmdList)
        {
            DataRead_WordLists DicPhraser = new DataRead_WordLists(type);
            DicPhraser.ProcessCommand(filename, CmdList);
        }
    }
}

/*
             DataRead_WordLists CommandListPhraser = new DataRead_WordLists(filename);
            Dictionary<string, string> wordDic_toAppend = CommandListPhraser.GetWordLits();

            foreach (KeyValuePair<string, string> item in wordDic_toAppend)
            {
                AddSafe(CmdList, item.Key, item.Value);
            }


    var students = new Dictionary<int, string>();
    students.AddSafe(1, "Apple");
    students.AddSafe(1, "Orange")

    public static void AddSafe(this Dictionary<int, string> dictionary, int key, string value)
{
    if (!dictionary.ContainsKey(key))
        dictionary.Add(key, value);
}

 */
