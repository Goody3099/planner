using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        public string nameOfCity = "CityOne";
        public string mayor = "Jenny";
        public int yearCityEst = 1775;
        public List<Building> collectionOfBuildings = new List<Building>();
        public void addBuilding(Building x)
        {
            collectionOfBuildings.Add(x);
        }
    }
}