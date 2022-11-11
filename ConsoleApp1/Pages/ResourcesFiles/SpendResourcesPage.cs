using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages.Shared;
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
            //TODO: Rename the files and classes to be Building related, and review the location on the files

            //Notify user of what resources he has
            Extension_Methods.ViewStatus(Storage.ResourcesList.OfType<IViewStatus>().ToList());

            Console.WriteLine("Press 'b' to see your Buildings");
            Console.WriteLine("Press 'c' to create Buildings");
            Console.WriteLine("Press 'm' to navigate back to the Menu");

            var key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "b":
                    Extension_Methods.ViewStatus(Storage.BuildingsList.OfType<IViewStatus>().ToList());
                    SpendResources();
                    break;

                case "c":
                    CreateItem item = new CreateItem();
                    item.Create(Storage.BuildingsList);
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
