using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    static class FrameBuffer
    {
        public static List<string> frame { get; set; }
        public static List<string> type { get; set; }
        static FrameBuffer()
        {
            List<string> f = new List<string>();

            f.Add(@"");
            f.Add(@"");
            f.Add(@"                                                       ████████\ ████████\  ██████\ ████████\");
            f.Add(@"                                                       \__██  __|██  _____|██  __██\\__██ __|");
            f.Add(@"                                                 ██████\  ██ |   ██ |      ██ /  \__|  ██ |");
            f.Add(@"                                                 \____██\ ██ |   █████\    \██████\    ██ |");
            f.Add(@"                                                 ███████ |██ |   ██  __|    \____██\   ██ |");
            f.Add(@"                                                ██  __██ |██ |   ██ |      ██\   ██ |  ██ |");
            f.Add(@"                                                \███████ |██ |   ████████\ \██████  |  ██ |");
            f.Add(@"                                                 \_______|\__|   \________| \______/   \__|");
            f.Add(@"");
            f.Add(@"");
            f.Add(@"                             ██████\        ██\                                 ██\");
            f.Add(@"                            ██  __██\       ██ |                                ██ |");
            f.Add(@"                            ██ /  ██ | ███████ |██\    ██\  ██████\  ███████\ ██████\   ██\   ██\  ██████\   ██████\");
            f.Add(@"                            ████████ |██  __██ |\██\  ██  |██  __██\ ██  __██\\_██  _|  ██ |  ██ |██  __██\ ██  __██\");
            f.Add(@"                            ██  __██ |██ /  ██ | \██\██  / ████████ |██ |  ██ | ██ |    ██ |  ██ |██ |  \__|████████ |");
            f.Add(@"                            ██ |  ██ |██ |  ██ |  \███  /  ██   ____|██ |  ██ | ██ |██\ ██ |  ██ |██ |      ██   ____|");
            f.Add(@"                            ██ |  ██ |\███████ |   \█  /   \███████\ ██ |  ██ | \████  |\██████  |██ |      \███████\ ");
            f.Add(@"                            \__|  \__| \_______|    \_/     \_______|\__|  \__|  \____/  \______/ \__|       \_______|");
            f.Add(@"");
            f.Add(@"                                                  (A Learning Project to explore C# by A4L)");
            f.Add("");
                       
            frame = f.ToList();

            List<string> t = new List<string>();
            t.Add("This project represents my attempts to learn C# in a more organic way than working through a textbook. I started programming in C# about 2 weeks before I started this project after working through about 2/3rds of a book called \"The C# Players Guide\".");
            t.Add("");
            t.Add("I spent a little longer than I wanted to on this project and would probably do it very differently if I started again, but for now, this application remains as a marker in the continuing learning process I have tasked for myself.");
            t.Add("");
            t.Add("This test game represents an attempt to produce a text adventure game. Type commands into the console to play!");
            t.Add("");
            t.Add("Have Fun");
            t.Add("  --A4L");

            type = t.ToList();
        }
    }
}
