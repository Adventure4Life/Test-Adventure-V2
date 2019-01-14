using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Area
    {
        //Data Reading Variables.
        private string areaName;
        private string areaLook_Description;
        private List<string> cinimatic;
        private List<Exit> exitsFromArea;
        private List<Items> itemsInRoom;

        //State Switches
        public bool FirstTimeEntered;

        //Constructor
        public Area()
        {
            // Data Reading variables
            areaName = "<areaName goes here>";
            areaLook_Description = "<description goes here>";
            cinimatic = new List<string>();
            exitsFromArea = new List<Exit>();
            itemsInRoom = new List<Items>();

            //State Switches
            FirstTimeEntered = true;
        }

        // Data variables
        public string Name() => areaName;
        public string LookDescription() => areaLook_Description; 
        public List<string> Cinamatic() => cinimatic; 
        public List<Exit> Exits() => exitsFromArea;
        public List<Items> ItemList() { return itemsInRoom;}

        // Switch Variables
        public bool sCinamaticHasPlayed { get; set; } = false;

        public void SetName(string importLine)
        {
            areaName = importLine;
        }
        public void SetLook_Description(string importLine)
        {
            areaLook_Description = importLine;
        }
        public void SetCinimatic(List<string> c)
        {
            cinimatic = new List<string>(c);
        }

        public void AddExit(Exit exit)
        {
            exitsFromArea.Add(exit);
        }

        public void AddItem(Items item)
        {
            itemsInRoom.Add(item);
        }

        // Commands
        public void LookArea()
        {

        }

    }
}
