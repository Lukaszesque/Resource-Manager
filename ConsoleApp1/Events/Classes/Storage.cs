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
        public static List<EntityTypes> ResourcesList = new List<EntityTypes> { };
        public static List<EntityTypes> BuildingsList = new List<EntityTypes>();

        //TODO: This belongs in the Shared folder. Refactor it to account for Buildings
        public static void DisplayResourcesInStorage(List<EntityTypes> entityList)
        {
            if (entityList.Count > 0)
            {
                string x = string.Empty;

                foreach (var item in entityList)
                {
                    x = item.ItemName + ", ";
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
