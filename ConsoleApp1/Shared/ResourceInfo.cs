using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.Shared;
using ConsoleApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Constants;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1.Shared
{
    internal class ItemInfo
    {
        internal void ViewStatus(List<EntityTypes> entityList, string entityType)
        {
            if (entityList.Count == 0)
            {
                Console.WriteLine($"You do not have any {entityType}s yet.");
            }
            else
            {
                Console.WriteLine($"You currently have {entityList.Count} type of {entityType} in your collection");
                Console.WriteLine($"The resources that you have are as following:");
            }

            foreach (var item in entityList)
            {
                Console.WriteLine("");
                Console.WriteLine($"Resource: " + item.ItemName);
                Console.WriteLine($"Level: " + item.ItemLevel);
                Console.Write($"Amount: {item.ItemCounter}");
                Console.WriteLine();
            }
        }
        internal void GetResources()
        {
            //#1: Refactor this so that user presses a button to generate a resource. The resource is modified by the Building level.
            Console.Clear();

            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Wood)) 
                { 
                    Console.WriteLine("Press 'w' to add more Wood");
                }
            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Stone))
            {
                Console.WriteLine("Press 's' to add more Stone");
            }
            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Gold))
            {
                Console.WriteLine("Press 'g' to add more Gold");
            }

            string key = new Extension_Methods().storeKey();

            switch (key)
            { 
                //TODO #2: Add this for Stone and Gold
                case "w":
                GetResource(new DTOResources().Wood);               
                break;
            }

        }

        //TODO #1: Rename this method. Implement parameter for key input. Make it work for other Resources
        private void GetResource(string resourceName)
        {
            var objectRef = Storage.ResourcesList.FirstOrDefault(i => i.ItemName == resourceName);
            float addedAmount = 100;

            if (objectRef?.ItemLevel > 0) addedAmount *= objectRef.ItemLevel;
            if (objectRef != null) objectRef.ItemCounter += addedAmount;
            Console.Clear();
            Console.WriteLine($"{addedAmount} added to {resourceName}. You now have {objectRef?.ItemCounter} {resourceName}.");

            //The player can add more wood or navigate back to the menu
            Console.WriteLine("Press 'w' to continue adding Wood");
            Console.WriteLine("Press any other key to navigate back to the Menu");
            string key2 = new Extension_Methods().storeKey();

            switch (key2)
            {
                case "w":
                    GetResource(new DTOResources().Wood);
                    break;

                default:
                    new MenuPage().Menu();
                    break;
            }

        }
    }
}
