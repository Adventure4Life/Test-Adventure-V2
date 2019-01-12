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
        private string areaLook_enter;
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
            areaLook_enter = "<areaLook_Description you only see once when you enter the room>";
            exitsFromArea = new List<Exit>();
            itemsInRoom = new List<Items>();

            //State Switches
            FirstTimeEntered = true;
        }

        #region Variable Properties - Get'er and Set'ers
        #region variable properties (Get'ers)
        public string Name() => areaName;
        public string LookDescription() => areaLook_Description; 
        public string LookEnter() => areaLook_enter; 
        public List<Exit> Exits() => exitsFromArea;
        public List<Items> ItemList() { return itemsInRoom;}
        #endregion

        #region variable properties (Set'ers)
        public void SetName(string importLine)
        {
            areaName = importLine;
        }

        public void SetLook_Description(string importLine)
        {
            areaLook_Description = importLine;
        }
        public void SetLook_Enter(string importLine)
        {
            areaLook_enter = importLine;
        }
        #endregion
        #endregion

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
