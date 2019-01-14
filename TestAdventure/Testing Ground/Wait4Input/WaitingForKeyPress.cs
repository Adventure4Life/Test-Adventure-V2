using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Ground
{
    class WaitingForKeyPress
    {
        public void TestKeyPressCode()
        {
            do { } // do nothing in here.. just loop so it acts like a pause
            while (!Console.KeyAvailable);
            while (Console.KeyAvailable) { Console.ReadKey(true); }


            for (int i = 0; i<2000; i++)
            {
                Console.Write('*');
            }
        }
    }
}
