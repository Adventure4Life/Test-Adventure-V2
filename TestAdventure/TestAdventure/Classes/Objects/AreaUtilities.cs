using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class AreaUtilities
    {
        public static void ActivateArea(Area area)
        {
            //Console.WriteLine(area.Name());
            

            switch (area.sCinamaticHasPlayed)
            {
                case false:
                    {
                        area.sCinamaticHasPlayed = true;
                        FrameBuffer.type = area.Cinamatic();
                        PrintBuffer.PrintType();
                        break; }
                case true:
                    { break; }
            }
        }
    }
}
