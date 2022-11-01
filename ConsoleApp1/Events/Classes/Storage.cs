using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    class Storage
    {
        public static List<Resources> ResourcesList = new List<Resources> { };
        public static List<Building> BuildingsList = new List<Building>();

        public static void DisplayResourcesInStorage()
        {
            if (ResourcesList.Count > 0)
            {
                string x = string.Empty;

                foreach (var item in ResourcesList)
                {
                    x = item.Name + ", ";
                }
                Console.WriteLine();
                Console.WriteLine($"Your resources are: {x}");
            }
            else
            {
                Console.WriteLine("You do not have any resources yet.");
            }
        }

    }
}
