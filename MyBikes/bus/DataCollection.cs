using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyBikes.bus
{
    public class DataCollection
    {
        private static List<Bike> listOfBikes = new List<Bike>();

        public static List<Bike> ListOfBikes
        {
            get { return listOfBikes; }
            set { listOfBikes = value; }
        }

        public static void Add(Bike newBike)
        {
            ListOfBikes.Add(newBike);
        }

        public static void Remove(Bike newBike)
        {
            ListOfBikes.Remove(newBike);
        }

        public static void RemoveAt(int currentIndex)
        {
            ListOfBikes.RemoveAt(currentIndex);
        }

        public static void InsertAt(int currentIndex, Bike currentBike)
        {
            listOfBikes.Insert(currentIndex, currentBike);
        }

        public static void Clear() { }

        public static Bike Search(int key, EnumBikeType type)
        {
            Bike foundBike = null;

            if (type == EnumBikeType.Road)
            {
                foundBike = new Road();
            }

            else if (type == EnumBikeType.Mountain)
            {
                foundBike = new Mountain();
            }

            else if (type == EnumBikeType.Electric)
            {
                foundBike = new Electric();
            }

            else if (type == EnumBikeType.Hybrid)
            {
                foundBike = new Hybrid();
            }

            foreach (Bike currentBike in ListOfBikes)
            {
                if (currentBike.SerialNumber == key)
                {
                    foundBike = currentBike;
                }
            }
            return foundBike;
        }

        public static List<Bike> GetBikeList()
        {
            return ListOfBikes;
        }

        public static List<Road> GetBikeRoadList()
        {
            List<Road> listOfRoad = new List<Road>();

            foreach (var currentBike in ListOfBikes)
            {
                if (currentBike is Road)
                {
                    Road currentRoad = new Road();
                    currentRoad = (Road)currentBike;
                    listOfRoad.Add(currentRoad);
                }
            }
            return listOfRoad;
        }

        public static List<Mountain> GetBikeMountainList()
        {
            List<Mountain> listOfMountain = new List<Mountain>();

            foreach (var currentBike in ListOfBikes)
            {
                if (currentBike is Mountain)
                {
                    Mountain currentMountain = new Mountain();
                    currentMountain = (Mountain)currentBike;
                    listOfMountain.Add(currentMountain);
                }
            }
            return listOfMountain;
        }

        public static List<Electric> GetBikeElectricList()
        {
            List<Electric> listOfElectric = new List<Electric>();

            foreach (var currentBike in ListOfBikes)
            {
                if (currentBike is Electric)
                {
                    Electric currentElectric = new Electric();
                    currentElectric = (Electric)currentBike;
                    listOfElectric.Add(currentElectric);
                }
            }
            return listOfElectric;
        }

        public static List<Hybrid> GetBikeHybridList()
        {
            List<Hybrid> listOfHybrid = new List<Hybrid>();

            foreach (var currentBike in ListOfBikes)
            {
                if (currentBike is Hybrid)
                {
                    Hybrid currentHybrid = new Hybrid();
                    currentHybrid = (Hybrid)currentBike;
                    listOfHybrid.Add(currentHybrid);
                }
            }
            return listOfHybrid;
        }
    }
}



    

