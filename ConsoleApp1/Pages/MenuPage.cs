using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages
{
    internal class MenuPage
    {
        public void Menu()
        {
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("You are at the main Menu. Please select from the below:");
            Console.WriteLine("");
            Console.WriteLine("Press 'r' to see the status of your resources");
            Console.WriteLine("Press 'c' to create your resources");
            Console.WriteLine("Press 'a' to add to your resources");
            Console.WriteLine("Press 'u' to spend your resources");

            var key = new Extension_Methods().storeKey();

            switch (key)
            {
                case "r":
                    new ResourceStatusPage().ResourceStatus(resourceType: new DTOResources().ItemType);
                    break;

                case "c":
                    new CreateItem().Create(Storage.ResourcesList, new DTOResources().ItemType);
                    break;

                case "a":
                    new ResourceInfo().GetResources();
                    break;

                case "u":
                    new SpendResourcesPage().SpendResources();
                    break;

                default:
                    new Extension_Methods().InputUnrecongnisedMessage();
                    Menu();
                    break;

            }
        }

    }
}
