using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.Shared
{
    internal class CreateItem
    {
        public void Create(List<EntityTypes> entityList, string entityType) 
            {

            Console.Clear();
            new ResourceInfo().ViewStatus(entityList, entityType);
            new UserMessages().ChooseFromTheBelow();

            switch (entityType) { 
                case "Building":

                    Console.WriteLine("");
                    Console.WriteLine($"Press 'm' to build a {new DTOBuildings().Mine}");
                    string key = new Extension_Methods().storeKey();
                    switch (key)
                    {
                        case "m":

                            CreateNewBuilding(new DTOBuildings().Mine);
                            break;

                        default:
                            CreateItem item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.BuildingsList, new DTOBuildings().ItemType);
                            break;
                    }
                    break;

                case "Resource":
                    Console.WriteLine("");
                    Console.WriteLine($"Press 'w' to build {new DTOResources().Wood}");
                    Console.WriteLine($"Press 's' to build {new DTOResources().Stone}");
                    Console.WriteLine($"Press 'g' to build {new DTOResources().Gold}");
                    key = new Extension_Methods().storeKey();
                    switch (key)
                    {
                        case "w":
                            CreateNewResource(new DTOResources().Wood);
                            break;

                        case "s":
                            CreateNewResource(new DTOResources().Stone);
                            break;

                        case "g":
                            CreateNewResource(new DTOResources().Gold);
                            break;

                        default:
                            CreateItem item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.ResourcesList, new DTOResources().ItemType);
                            break;
                    }
                    break;
            }

            new SpendResourcesPage().SpendResources();

        }
        //TODO: Merge this and building method together
        private void CreateNewResource(string resourceName)
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

            new MenuPage().Menu();
        }
        private void CreateNewBuilding(string buildingName)
        {
            //retreive the building from the list. If none is obtained then the variable  will be Null
            var builingObject = Storage.BuildingsList.FirstOrDefault(building => building.ItemName == buildingName);
            string BuildingType = "Building";

            if (builingObject == null)
            {
                Storage.BuildingsList.Add(new EntityTypes(BuildingType, buildingName));
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
