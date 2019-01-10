using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Level
    {
        //Public Variable
        public static Area[,] Layout { get; set; } = new Area[2, 2];

        public static void InitiliseLevel()
        {
            DataReader ReadData = new DataReader();
            Layout[0, 0] = ReadData.ImportAreaData("TestArea");
        }
    }
}
