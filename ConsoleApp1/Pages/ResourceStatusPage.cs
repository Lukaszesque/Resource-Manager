using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
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
            Extension_Methods.ViewStatus(Storage.ResourcesList.OfType<IViewStatus>().ToList());

            Console.WriteLine($"Press any key to navigate back to the menu");
            string key = Resources.storeKey();

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
