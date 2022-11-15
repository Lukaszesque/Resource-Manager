using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages.ResourceFiles;
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

            Constants.Extension_Methods.ViewStatus(entityList, entityType);

            switch (entityType) { 
                case "Building":

                    Console.WriteLine($"Press 'm' to build a {Constants.DTOs.DTOBuildings.Mine.Name}");
                    string key = Events.Classes.Resources.storeKey();
                    switch (key)
                    {
                        case "m":

                            Constants.Extension_Methods.CreateNewBuilding(Constants.DTOs.DTOBuildings.Mine.Name);
                            break;

                        default:
                            CreateItem item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.BuildingsList, DTOBuildings.Mine.Type);
                            break;
                    }
                    break;

                case "Resource":
                    Console.WriteLine($"Press 'w' to build {Constants.DTOs.DTOResources.Wood}");
                    Console.WriteLine($"Press 's' to build {Constants.DTOs.DTOResources.Stone}");
                    Console.WriteLine($"Press 'g' to build {Constants.DTOs.DTOResources.Gold}");
                    key = Events.Classes.Resources.storeKey();
                    switch (key)
                    {
                        case "w":
                            Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Wood);
                            break;

                        case "s":
                            Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Stone);
                            break;

                        case "g":
                            Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Gold);
                            break;

                        default:
                            CreateItem item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.ResourcesList, DTOResources.ItemType);
                            break;
                    }
                    break;
            }

            SpendResourcesPage.SpendResources();

        }
    }
}
