using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    class Storage
    {
        //TODO: static is inefficient - refactor these as non static properties
        public static List<Resources> ResourcesList = new List<Resources> { };
        public static List<Building> BuildingsList = new List<Building>();

        //TODO: This belongs in the Shared folder. Refactor it to account for Buildings
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
