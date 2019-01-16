using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{ 
    static class CommandDictonary
    {
        private static DataReader ReadData = new DataReader();
        private static Dictionary<string, string> CmdList_Defaults { get; set; }
        private static Dictionary<string, string> CmdList { get; set; }

        static CommandDictonary()
        {
            CmdList_Defaults = new Dictionary<string, string>();
            string type = "verbs";
            ReadData.ImportCommandData(type, "look", CmdList_Defaults);
            ReadData.ImportCommandData(type, "get", CmdList_Defaults);
            InitialiseDefautls();
        }

        public static void InitialiseDefautls()
        {
            CmdList = new Dictionary<string, string>(CmdList_Defaults);
        }

        public static Dictionary<string, string> GetCommandList()
        { return CmdList; }
    }
}
