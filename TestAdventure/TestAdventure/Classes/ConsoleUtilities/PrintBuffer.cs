using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class PrintBuffer
    {
        private static bool breakLoop = false;

        /// <summary>
        /// PrintStory : Prints out a long string of text Character by Character. Pressing any key will skip to end!
        /// </summary>
        //static private bool breakLoop = false;
        public static void PrintTyperWritter(string line)
        {
            line = line + "\n";
            Console.CursorVisible = false;
            if (!breakLoop)
            {
                for (int i = 0; i < line.Length; i++) // loop through string charIndex by charIndex
                {
                    // if a key is pressed break the loop and print the reminder of the line.
                    while (Console.KeyAvailable)
                    {
                        breakLoop = true;
                        Console.Write(line.Substring(i, line.Length - i));
                        break;
                    }

                    // If we are at the end of the line or the breakLoop is true break out of for loop with out printing more chars.
                    if (breakLoop || i == line.Length)
                    {
                        Console.ReadKey(); break;
                    }

                    // Print each char in the line
                    char c = line[i];
                    Console.Write(c);
                    Thread.Sleep(5);
                }
            }
            else Console.Write(line);
            Console.CursorVisible = true;
        }

        static public void PrintFrame()
        {
            Console.Clear();
            PrintScreen_Frame();
        }

        static public void PrintType()
        {
            PrintScreen_Type();
        }

        static private void PrintScreen_Type()
        {
            //PrintTyperWritter(TextUtils.WordWrap(FrameBuffer.type));
            foreach (var line in FrameBuffer.type)
            {
                PrintTyperWritter(TextUtils.WordWrap(line));
                //PrintTyperwritter(line);
            }
        }

        static private void PrintScreen_Frame()
        {
            foreach (var line in FrameBuffer.frame)
            {
                Console.WriteLine(line);
            }
        }

    }
}
