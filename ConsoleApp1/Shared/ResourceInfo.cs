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
        public void ViewStatus(List<EntityTypes> entityList, string entityType)
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
        public void GetResources()
        {
            Console.Clear();
            if (Storage.ResourcesList.Count == 0)
            {
                Console.WriteLine("You do not have any resources yet.");
              
                new CreateItem().Create(Storage.ResourcesList, new DTOResources().Wood);
            }
            else
            {
                new ItemInfo().ViewStatus(Storage.ResourcesList, new DTOResources().ItemType);
                Console.WriteLine("");
                Console.WriteLine("Please select which Resource to add to:");
                Console.WriteLine("");

                for (int i = 0; i < Storage.ResourcesList.Count; i++)
                {
                    Console.WriteLine($"Press {i} to add to {Storage.ResourcesList[i].ItemName}"

                        );

                    if (i > 9)
                    {
                        Console.WriteLine("Too many Resources are created. Please delete some resources.");
                    }
                }

                int key = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("Please select how much resources to add");
                float amount = Convert.ToSingle(Console.ReadLine());

                //TODO: #1 add the logic to update the amount
                Storage.ResourcesList[key].ItemCounter += amount;
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"You now have {Storage.ResourcesList[key].ItemCounter} of {Storage.ResourcesList[key].ItemName}");
                new UserMessages().PressAnyKeyToNavigateToMenu();
            }
        }
    }
}
