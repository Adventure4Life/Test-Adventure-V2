using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class CmdInput
    {
        //Public Variables
        private static string rawInput = "";

        public static void GetInput(string input)
        {
            rawInput = input;
        }
    }
}
