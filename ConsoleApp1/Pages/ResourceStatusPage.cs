using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    internal class ResourceStatusPage
    {
        public static void ResourceStatus()
        {
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine($"You currently have {Storage.ResourcesList.Count} type of Resources in your collection");
            Console.WriteLine($"The resources that you have are as following:");
            foreach (var item in Storage.ResourcesList)
            {
                Console.WriteLine($"Resource: " + item.ResourceName);
                Console.WriteLine($"Amount: " + item.ResourceCounter);
                Console.WriteLine();
            }

            Console.WriteLine($"Press any key to navigate back to the menu");
            string key = ResourceManager.storeKey();

            switch (key)
            {
                default:
                Console.WriteLine();
                Console.WriteLine("Navigating to the Menu.");
                MenuPage.Menu();
                break;
            }

        }
    }
}
