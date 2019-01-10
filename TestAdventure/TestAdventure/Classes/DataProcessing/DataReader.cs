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
    }
}
