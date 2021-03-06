﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAdventure
{ 
    class AreaKeys
    {
        public string areaName { get; }
        public string areaLook_Description { get; }

        public string areaCinamatic_Start { get; }
        public string areaCinamatic_End { get; }

        public string exitStart { get; }
        public string exitEnd { get; }

        public string itemsStart { get; }
        public string itemsEnd { get; }

        public AreaKeys()
        {
            areaName = "//--AREA_NAME:";
            areaLook_Description = "//--AREA_LOOK:";

            areaCinamatic_Start = "//--AREA_CINAMATIC_START:";
            areaCinamatic_End = "//--AREA_CINAMATIC_END:";

            exitStart = "//-EXIT_START";
            exitEnd = "//-EXIT_END";

            itemsStart = "//LIST_OF_ITEMS_IN_AREA--START";
            itemsEnd = "//LIST_OF_ITEMS_IN_AREA--END";
        }

    }
    class ExitKeys
    {
        public string name { get; } = "--NAME:";
        public string isOpen { get; } = "--IS_OPEN:";

        public string lookAreaOpen { get; } = "--LOOK_AREA_OPEN:";
        public string lookAreaClosed { get; } = "--LOOK_AREA_CLOSED:";

        public string LookAtOpen { get; } = "--LOOK_AT_OPEN:";
        public string LookAtClosed { get; } = "--LOOK_AT_CLOSED:";

        public string Use_Open { get; } = "--USE_OPEN:";
        public string Use_CLosed { get; } = "--USE_CLOSED:";

    }
    class DataRead_Area
    {
        private List<string> fileData;
        private string filePath;
        private string fileName;
        private Area area;
        AreaKeys areaKeys;
        ExitKeys exitKeys;

        // Return Area() 
        public Area GetArea()
        { return area; }

        //Constructor
        public DataRead_Area(string name)
        {
            area = new Area();
            areaKeys = new AreaKeys();
            exitKeys = new ExitKeys();
            filePath = @"Data\areas\";
            fileName = name;
            fileData = ReadDataFile.Load_DataFile(filePath, fileName).ToList();
            ProcessData();
        }

        private void ProcessData()
        {
            area.SetName(ReadDataFile.Read_RawSingleLine(areaKeys.areaName, fileData));
            area.SetLook_Description(ReadDataFile.Read_RawSingleLine(areaKeys.areaLook_Description, fileData));
            area.SetCinimatic(BetweenUniqueBrackets(areaKeys.areaCinamatic_Start, areaKeys.areaCinamatic_End));
            //ProcessAllExits();
            //ProcessAllItems();
        }

        //Between Brackets, Read RAW lines into a List<string>
        private List<string> BetweenUniqueBrackets(string start, string end)
        {
            List<string> data = new List<string>();
            int[] brackets = ReadDataFile.FindUniqueBrackets(start, end, fileData);
            data = ReadDataFile.Read_Cinamatic(brackets[0], brackets[1], fileData);
            return data;
        }

        private void ProcessAllItems()
        {
            //ExitKeys exitKeys = new ExitKeys();
            Dictionary<string, object> BracketData = ReadDataFile.Read_BracketCount(areaKeys.itemsStart, areaKeys.itemsEnd, fileData); //("count", bracketCount); | ("startList", bracketIndex_Start); | ("endList", bracketIndex_End);

            List<int> bracketIndex_Start = BracketData["startList"] as List<int>;
            List<int> bracketIndex_End = BracketData["endList"] as List<int>;

            for (int i = bracketIndex_Start[0]+1; i < bracketIndex_End[0]; i++)
            {
                DataRead_Items BuildItem = new DataRead_Items(fileData[i]);
                area.AddItem(BuildItem.GetItem());
            }
        }


        private void ProcessAllExits()
        {
            ExitKeys exitKeys = new ExitKeys();
            Dictionary<string, object> BracketData = ReadDataFile.Read_BracketCount(areaKeys.exitStart, areaKeys.exitEnd, fileData); //("count", bracketCount); | ("startList", bracketIndex_Start); | ("endList", bracketIndex_End);

            int exitAmount = (int)BracketData["count"];
            List<int> bracketIndex_Start = BracketData["startList"] as List<int>;
            List<int> bracketIndex_End = BracketData["endList"] as List<int>;

            for (int i = 0; i < exitAmount; i++)
            {
                area.AddExit(ProcessExits(bracketIndex_Start[i], bracketIndex_End[i]));
            }
        }

        private Exit ProcessExits(int start, int end)
        {
            Exit exit = new Exit();
            start = start + 1;
            for (int i = start; i < end; i++)
            {
                exit.name = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.name, fileData, start, end);
                exit.open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.isOpen, fileData, start, end).Equals("true");
                exit.look_area_open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.lookAreaOpen, fileData, start, end);
                exit.look_area_closed = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.lookAreaClosed, fileData, start, end);
                exit.look_at_open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.LookAtOpen, fileData, start, end);
                exit.look_at_closed = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.LookAtClosed, fileData, start, end);
                exit.use_Open = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.Use_Open, fileData, start, end);
                exit.use_Closed = ReadDataFile.ReadData_LinesInsideBrackets(exitKeys.Use_CLosed, fileData, start, end);
            }

            return exit;
        }
    }
}
