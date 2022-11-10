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
            Console.WriteLine("Hello and welcome to the Resource Manager!");
            Console.WriteLine("Press 'm' to navigate to the Main Menu");

            string key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "m":
                Console.WriteLine("");
                MenuPage.Menu();
                break;

                default:
                Console.WriteLine("Input not recognised...");
                Welcome();
                break;
            }
        }
    }
}
