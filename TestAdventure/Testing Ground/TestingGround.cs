using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Ground
{
    class TestingGround
    {
        static void Main(string[] args)
        {
            TestKeyPresses();
            char huh = Console.ReadKey().KeyChar;
            Console.WriteLine("\n" + huh);
            Console.ReadKey();
        }

        static void TestKeyPresses()
        {
            WaitingForKeyPress test = new WaitingForKeyPress();
            test.TestKeyPressCode();
        }
    }
}
