using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class GameState
    {
        private static bool gameIsRunning = true;

        public static bool GameHasNotEnded()
        {
            return gameIsRunning;
        }

    }
}
