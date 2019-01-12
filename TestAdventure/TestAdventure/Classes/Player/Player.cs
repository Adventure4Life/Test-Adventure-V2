using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class Player
    {
        private static int PosX { get; set; }
        private static int PosY { get; set; }

        static Player()
        {
            PosX = 0;
            PosY = 0;
        }

        public static Area GetCurrentArea()
        {
            return Level.Layout[PosX, PosY];
        }

    }
}
