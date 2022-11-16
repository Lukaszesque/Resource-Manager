using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages.Shared;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.ResourceFiles
{
    internal class SpendResourcesPage
    {
        public void SpendResources()
        {
            //TODO: Rename the files and classes to be Building related, and review the location on the files

            //Notify user of what resources he has
            new ResourceInfo().ViewStatus(Storage.ResourcesList, new DTOBuildings().ItemType);

            Console.WriteLine("Press 'b' to see your Buildings");
            Console.WriteLine("Press 'c' to create Buildings");
            Console.WriteLine("Press 'm' to navigate back to the Menu");

            var key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "b":
                    new ResourceInfo().ViewStatus(Storage.BuildingsList, new DTOBuildings().ItemType);
                    SpendResources();
                    break;

                case "c":
                    new CreateItem().Create(Storage.BuildingsList, new DTOBuildings().ItemType);
                    break;

                case "m":
                    new MenuPage().Menu();
                    break;

                default:
                    new Extension_Methods().InputUnrecongnisedMessage();
                    SpendResources();
                    break;
            }


        }
    }
}
