using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    internal class MenuPage
    {
        public static void Menu()
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("You are at the main Menu");
            Console.WriteLine("Press 'r' to see the status of your resources");
            Console.WriteLine("Press 'c' to create your resources");
            Console.WriteLine("Press 'a' to add to your resources");
            Console.WriteLine("Press 'u' to spend your resources");

            var key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "r":
                    ResourceStatusPage.ResourceStatus();
                    break;

                case "c":
                    ResourceManagerPage.ResourceManager();
                    break;

                case "a":
                    Extension_Methods.GetResources();
                    break;

                case "u":
                    SpendResourcesPage.SpendResources();
                    break;

                default:
                    Constants.Extension_Methods.InputUnrecongnisedMessage();
                    Menu();
                    break;

            }
        }

    }
}
