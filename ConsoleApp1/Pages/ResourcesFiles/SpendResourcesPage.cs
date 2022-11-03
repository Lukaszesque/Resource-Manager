using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.ResourceFiles
{
    internal class SpendResourcesPage
    {
        public static void SpendResources()
        {
            //TODO: Implement the logic for this page

            //Notify user what resources he has
            Extension_Methods.ViewStatus(Storage.ResourcesList.OfType<IViewStatus>().ToList());

            Console.WriteLine("Press 'b' to see your Buildings");
            Console.WriteLine("Press 'c' to create Buildings");
            Console.WriteLine("Press 'm' to navigate back to the Menu");

            var key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "b":
                    Console.WriteLine("To be implemented...");
                    break;

                case "c":
                    Console.WriteLine("To be implemented");
                    break;

                case "m":
                    MenuPage.Menu();
                    break;

                default:
                    Extension_Methods.InputUnrecongnisedMessage();
                    SpendResources();
                    break;


            }


        }
    }
}
