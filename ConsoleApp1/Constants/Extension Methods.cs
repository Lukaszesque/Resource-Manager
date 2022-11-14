using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constants
{
    internal class Extension_Methods
	{
		public static void InputUnrecongnisedMessage() 
			{
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Input not recognised...");
			}

        public static void GetResources()
        {
            Console.WriteLine("---------------------------------------------------------");

            if (Storage.ResourcesList.Count == 0)
            {
                Console.WriteLine("You do not have any resources yet.");
                
                CreateItem item = new CreateItem();
                item.Create(Storage.ResourcesList, DTOResources.Wood.Type);
            }
            else
            {
                Storage.DisplayResourcesInStorage(Storage.ResourcesList);
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

                //TODO: Implement a resource modifier

                Console.WriteLine("---------------------------------------------------------");
                //Console.WriteLine($"The {amount} of {Storage.ResourcesList[key].ItemName} is multiplied by the Modifier value of {Storage.ResourcesList[key].Modifier}. This result in a total increase of {amount * Storage.ResourcesList[key].Modifier}");
                Console.WriteLine($"You now have {Storage.ResourcesList[key].ItemCounter} of {Storage.ResourcesList[key].ItemName}");
                MenuPage.Menu();
            }
        }
        //TODO: Merge this and building method together
        public static void CreateNewResource(string resourceName) 
            {
            string itemType = "Resource";
            //Creates an instance of a resource, but only if one does not already exist

            if (Storage.ResourcesList.Any(item => item.ItemName == resourceName)) 
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You already have {resourceName}.");
                }
            else 
                {
                Storage.ResourcesList.Add(new EntityTypes(itemType, resourceName));
                }

            MenuPage.Menu();
        }

        public static void ViewStatus(List<EntityTypes> entityList, string entityType) 
            {
            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            if (entityList.Count == 0) 
                {Console.WriteLine($"You do not have any {entityType}s yet");}
            else
                { 
                Console.WriteLine($"You currently have {entityList.Count} type of {entityType} in your collection");
                Console.WriteLine($"The resources that you have are as following:");
            }
            
            foreach (var item in entityList)
            {
                Console.WriteLine($"Resource: " + item.ItemName);
                Console.WriteLine($"Amount: " + item.ItemCounter);
                Console.WriteLine();
            }
        }


        public static void CreateNewBuilding(string buildingName)
        {
            //retreive the building from the list. If none is obtained then the variable  will be Null
            var builingObject = Storage.BuildingsList.FirstOrDefault(building => building.ItemName == buildingName);
            string BuildingType = "Building";

            if (builingObject == null)
            {
                Storage.BuildingsList.Add(new EntityTypes(BuildingType,buildingName));
                Console.WriteLine($"You have constructed a new {buildingName}!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"You already have {builingObject.ItemName} constructed. It's level is {builingObject.ItemCounter}");
            }
        }
    }
}

