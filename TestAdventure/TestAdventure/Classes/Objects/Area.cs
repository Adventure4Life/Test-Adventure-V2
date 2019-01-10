using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class Area
    {
        private string areaName;
        private string areaBaseDescription;
        private List<Exit> exitsFromArea;
        private List<Items> itemsInRoom;

        public Area()
        {
            areaName = "<areaName goes here>";
            areaBaseDescription = "<description goes here>";
            exitsFromArea = new List<Exit>();
            itemsInRoom = new List<Items>();
        }

        #region Variable Properties - Get'er and Set'ers
        #region variable properties (Get'ers)
        public string GetName() => areaName;
        public string GetDescription() => areaBaseDescription;
        public List<Exit> GetExits() => exitsFromArea;
        public List<Items> GetItems() { return itemsInRoom;}
        #endregion

        #region variable properties (Set'ers)
        public void SetName(string importLine)
        {
            areaName = importLine;
        }

        public void SetDescription(string importLine)
        {
            areaBaseDescription = importLine;
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

    }
}
