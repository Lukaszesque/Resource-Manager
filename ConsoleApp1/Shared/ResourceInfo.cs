using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.Shared;
using ConsoleApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Shared
{
    internal class ResourceInfo
    {
        public void GetResources()
        {
            Console.WriteLine("---------------------------------------------------------");

            if (Storage.ResourcesList.Count == 0)
            {
                Console.WriteLine("You do not have any resources yet.");

                CreateItem item = new CreateItem();
                item.Create(Storage.ResourcesList, new DTOResources().Wood);
            }
            else
            {
                new DisplayInformation().DisplayResourcesInStorage(Storage.ResourcesList);
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

                Console.WriteLine("---------------------------------------------------------");
                //Console.WriteLine($"The {amount} of {Storage.ResourcesList[key].ItemName} is multiplied by the Modifier value of {Storage.ResourcesList[key].Modifier}. This result in a total increase of {amount * Storage.ResourcesList[key].Modifier}");
                Console.WriteLine($"You now have {Storage.ResourcesList[key].ItemCounter} of {Storage.ResourcesList[key].ItemName}");
                new MenuPage().Menu();
            }
        }

        public void ViewStatus(List<EntityTypes> entityList, string entityType)
        {
            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            if (entityList.Count == 0)
            { Console.WriteLine($"You do not have any {entityType}s yet"); }
            else
            {
                Console.WriteLine($"You currently have {entityList.Count} type of {entityType} in your collection");
                Console.WriteLine($"The resources that you have are as following:");
            }

            foreach (var item in entityList)
            {
                Console.WriteLine($"Resource: " + item.ItemName);
                Console.WriteLine($"Level: " + item.ItemLevel);
                Console.Write($"Amount: {item.ItemCounter}");
                Console.WriteLine();
            }
        }
    }
}
