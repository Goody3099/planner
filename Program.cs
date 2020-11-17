using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Width = 10;
            FiveOneTwoEigth.Depth = 5;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Purchase("Jasmin");
            FiveOneTwoEigth.dateTime();
            Building OneTwoThreeMain = new Building("123 Main");
            OneTwoThreeMain.Width = 9;
            OneTwoThreeMain.Depth = 9;
            OneTwoThreeMain.Stories = 20;
            OneTwoThreeMain.Purchase("Matthew");
            OneTwoThreeMain.dateTime();
            Building FiveThreeSixBroad = new Building("536 Broad");
            FiveThreeSixBroad.Width = 15;
            FiveThreeSixBroad.Depth = 12;
            FiveThreeSixBroad.Stories = 100;
            FiveThreeSixBroad.Purchase("Jerry");
            FiveThreeSixBroad.dateTime();
            List<Building> listOfBuildings = new List<Building>();
            listOfBuildings.Add(FiveOneTwoEigth);
            listOfBuildings.Add(OneTwoThreeMain);
            listOfBuildings.Add(FiveThreeSixBroad);
            foreach (var item in listOfBuildings)
            {
                Console.Write($@"

                {item.A()}
                ---------------
                Designed by {item.D()}
                COnstructed on {item.T()}
                Owned by {item.O()}
                {item.Volume} cubic meters of space
                ");
            }
        }
    }
}
