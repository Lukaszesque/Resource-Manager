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
            //TODO #1: The resource should be modified by the Building level.
            //TODO #1a: Implement logic that prevents the user from adding resources if none exist
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
                case KeyInputs.WoodKey:
                GetResource(new DTOResources().Wood, KeyInputs.WoodKey);               
                break;

                case KeyInputs.StoneKey:
                    GetResource(new DTOResources().Gold, KeyInputs.StoneKey);
                    break;

                case KeyInputs.GoldKey:
                    GetResource(new DTOResources().Gold, KeyInputs.GoldKey);
                    break;
            }

        }

        //TODO #1: Rename this method. Implement parameter for key input. Make it work for other Resources
        private void GetResource(string resourceName, string keyInput)
        {
            var objectRef = Storage.ResourcesList.FirstOrDefault(i => i.ItemName == resourceName);
            if (objectRef == null) { 
                Console.WriteLine("There is a problem - could not find the resource in the Storage...");
                new UserMessages().PressAnyKeyToNavigateToMenu();
                }
            float addedAmount = 100;

            if (objectRef?.ItemLevel > 0) addedAmount *= objectRef.ItemLevel;
            if (objectRef != null) objectRef.ItemCounter += addedAmount;
            Console.Clear();
            Console.WriteLine($"{addedAmount} added to {resourceName}. You now have {objectRef?.ItemCounter} {resourceName}.");

            //The player can add more resources or navigate back to the menu
            Console.WriteLine($"Press '{keyInput}' to continue adding {resourceName}");
            Console.WriteLine("Press any other key to navigate back to the Menu");
            string key2 = new Extension_Methods().storeKey();

            if (key2 == keyInput) {
                GetResource(resourceName, keyInput);
            }
            else {
                new MenuPage().Menu();
            }
        }
    }
}
