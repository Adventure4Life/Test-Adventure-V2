using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{
    class ItemKeys
    {
        public string itemName { get; }
        public string itemCanBePickedip { get; }

        public string DescriptionDefault { get; }
        public string DescriptionDropped { get; }
        public string DescriptionGone { get; }

        public string getSuccess { get; }
        public string getNotAllowed { get; }

        public string nStart { get; }
        public string nEnd { get; }

        public string vStart { get; }
        public string vEnd { get; }

        // need NONE START/END
        // need verb START/END

        public ItemKeys()
        {
            itemName = "//--ITEM_NAME:";
            itemCanBePickedip = "//--ITEM_CAN_BE_PICKED_UP:";

            DescriptionDefault = "//--ROOM_DESCRIPTION_DEFAULT:";
            DescriptionDropped = "//--ROOM_DESCRIPTION_DROPPED:";
            DescriptionGone = "//--ROOM_DESCRIPTION_GONE:";

            getSuccess = "//--GET_ITEM_SUCCESS:";
            getNotAllowed = "//--GET_ITEM_NOT_ALLOWED:";

            nStart = "//--NOUN-START";
            nEnd = "//--NOUN-END";

            vStart = "//--VERB-START";
            vEnd = "//--VERB-END";
        }

    }
    class DataRead_Items
    {
        private List<string> fileData;
        private string filePath;
        private string fileName;
        private Items item;
        private ItemKeys itemKeys;

        // Return Item() 
        public Items GetItem()
        { return item; }

        public DataRead_Items(string name)
        {
            item = new Items();
            itemKeys = new ItemKeys();
            filePath = @"Data\items\";
            fileName = name;
            fileData = ReadDataFile.Read_DataFile(filePath, fileName);
            ProcessData();
        }

        private void ProcessData()
        {
            //Console.WriteLine("Processing : " + fileName);
            item.name = ReadDataFile.Read_SingleLine(itemKeys.itemName, fileData);
            item.PickedupAllowed = ReadDataFile.Read_SingleLine(itemKeys.itemCanBePickedip, fileData).Equals("true");

            item.description_Default = ReadDataFile.Read_SingleLine(itemKeys.DescriptionDefault, fileData);
            item.description_Dropped = ReadDataFile.Read_SingleLine(itemKeys.DescriptionDropped, fileData);
            item.description_Gone = ReadDataFile.Read_SingleLine(itemKeys.DescriptionGone, fileData);

            item.getItem_Success = ReadDataFile.Read_SingleLine(itemKeys.getSuccess, fileData);
            item.getItem_NotAllowed = ReadDataFile.Read_SingleLine(itemKeys.getNotAllowed, fileData);
        }
    }
}
