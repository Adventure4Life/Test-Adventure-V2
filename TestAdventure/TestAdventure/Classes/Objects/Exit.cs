using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Exit
    {
        public string name { get; set; } = "";
        public string look_area_closed { get; set; } = "";
        public string look_area_open { get; set; } = "";
        public string look_at_closed { get; set; } = "";
        public string look_at_open { get; set; } = "";
        public string use_Open { get; set; } = "";
        public string use_Closed { get; set; } = "";
        public bool open { get; set; } = true;

        public void SetOpenBool(string value)
        {
            open = false;
        }
    }
}
