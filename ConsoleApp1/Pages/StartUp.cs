using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;

namespace ConsoleApp1.Pages
{
    internal class StartUp
    {
        public void Welcome()
        {
            //Create an instance of Storage.

            Console.WriteLine("Hello and welcome to the Resource Manager!");
            Console.WriteLine("Press 'm' to navigate to the Main Menu");

            string key = new Extension_Methods().storeKey();

            switch (key)
            {
                case "m":
                Console.WriteLine("");
                new MenuPage().Menu();
                break;

                default:
                Console.WriteLine("Input not recognised...");
                Welcome();
                break;
            }
        }
    }
}
