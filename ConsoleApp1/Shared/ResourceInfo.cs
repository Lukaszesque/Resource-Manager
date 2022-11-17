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
                //TODO #2: This needs to be dryer and debugged
                case "w":
                float addedAmount = 100;
                if (Storage.BuildingsList[0].ItemLevel > 0) {addedAmount *= Storage.BuildingsList[0].ItemLevel;}
                    Storage.ResourcesList[0].ItemCounter += addedAmount;
                Console.WriteLine($"{addedAmount} added to wood. you now have {Storage.ResourcesList[0].ItemCounter} wood.");
                break;
            }



            //if (Storage.ResourcesList.Count == 0)
            //{
            //    Console.WriteLine("You do not have any resources yet.");

            //    new CreateItem().Create(Storage.ResourcesList, new DTOResources().Wood);
            //}
            //else
            //{
            //    new ItemInfo().ViewStatus(Storage.ResourcesList, new DTOResources().ItemType);
            //    Console.WriteLine("");
            //    Console.WriteLine("Please select which Resource to add to:");
            //    Console.WriteLine("");

            //    for (int i = 0; i < Storage.ResourcesList.Count; i++)
            //    {
            //        Console.WriteLine($"Press {i} to add to {Storage.ResourcesList[i].ItemName}"

            //            );

            //        if (i > 9)
            //        {
            //            Console.WriteLine("Too many Resources are created. Please delete some resources.");
            //        }
            //    }

            //    int key = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("---------------------------------------------------------");
            //    Console.WriteLine("Please select how much resources to add");
            //    float amount = Convert.ToSingle(Console.ReadLine());

            //    Storage.ResourcesList[key].ItemCounter += amount;
            //    Console.WriteLine("---------------------------------------------------------");
            //    Console.WriteLine($"You now have {Storage.ResourcesList[key].ItemCounter} of {Storage.ResourcesList[key].ItemName}");
            //    new UserMessages().PressAnyKeyToNavigateToMenu();
            //}
        }
    }
}
