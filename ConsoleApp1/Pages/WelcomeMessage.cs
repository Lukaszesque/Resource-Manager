using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;

namespace ConsoleApp1.Pages
{
    internal class WelcomeMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("Hi, I'm Nat Hunt. Welcome to the Resource Manager!");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("Press 'r' for the list of resources available");

            string key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                //TODO: Resolve the UI bug here
                case "r":
                Console.WriteLine("");
                ResourceStatusPage.ResourceStatus();
                break;

                default:
                Console.WriteLine("Input not recognised...");
                Welcome();
                break;
            }
        }
    }
}
