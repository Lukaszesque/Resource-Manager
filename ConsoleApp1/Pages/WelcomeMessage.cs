using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Events.Classes;

namespace ConsoleApp1.Pages
{
    internal class WelcomeMessage
    {
        public static void Welcome()
        {
            Console.WriteLine("Hi, I'm Nat Hunt. Welcome to the Resource Manager!");
            Console.WriteLine("Please choose from the following options:");
            Console.WriteLine("Press 'r' for the list of resources available");

            string key = Resources.storeKey();

            switch (key)
            {
                case "r":
                Console.WriteLine("");
                ResourceManagerPage.ResourceManager();
                break;

                default:
                Console.WriteLine("Input not recognised...");
                Welcome();
                break;
            }
        }
    }
}
