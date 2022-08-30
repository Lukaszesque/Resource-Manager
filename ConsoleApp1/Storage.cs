using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Storage
    {
        public static List<ResourceManager> ResourcesList = new List<ResourceManager> { };

        public static Storage programStorage = new Storage();

        public static void DisplayResourcesInStorage() 
            {
            if (Storage.ResourcesList.Count > 0)
            {
                string x = string.Empty;

                foreach (var item in Storage.ResourcesList)
                {
                    x = item.ResourceName + ", ";
                }
                Console.WriteLine($"Your resources are: {x}");
            }
            else 
            { 
                Console.WriteLine("You do not have any resources yet.");    
            }
        }

    }
}
