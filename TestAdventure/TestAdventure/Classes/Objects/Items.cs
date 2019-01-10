using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Items
    {
        //Private Variables
        public string name { get; set; } = "";
        public bool PickedupAllowed { get; set; } = true;
        public string description_Default { get; set; } = "";
        public string description_Dropped { get; set; } = "";
        public string description_Gone { get; set; } = "";
        public string getItem_NotAllowed { get; set; } = "";
        public string getItem_Success { get; set; } = "";
    }
}
