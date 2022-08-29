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
            Console.WriteLine("Press 'u' to upgrade your resources");

            var key = ResourceManager.storeKey();

            switch (key)
            {
                case "r":
                    ResourceStatusPage.ResourceStatus();
                    break;

                case "c":
                    ResourceManagerPage.ResourceManager();
                    break;

                case "u":
                    Console.WriteLine("Not yet implemented :D");
                    break;

                default:
                    Constants.Extension_Methods.InputUnrecongnisedMessage();
                    Menu();
                    break;

            }
        }

    }
}
