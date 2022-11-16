using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.ResourceFiles
{
    internal class ResourceStatusPage
    {
        public static void ResourceStatus(string resourceType)
        {
            new ResourceInfo().ViewStatus(Storage.ResourcesList, resourceType);

            Console.WriteLine($"Press any key to navigate back to the menu");
            string key = Events.Classes.Resources.storeKey();

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
