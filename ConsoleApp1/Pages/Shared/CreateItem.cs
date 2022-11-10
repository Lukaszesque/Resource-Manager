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
        
        public void Create(List<Resources> resourcesList) 
            {

            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"You currently have {resourcesList.Count} types of resources");

            Storage.DisplayResourcesInStorage();
            //TODO: if a resource exists, the user should not see an option to create it
            Console.WriteLine($"Press 'w' to create {Constants.DTOs.DTOResources.Wood.Name} resource");
            Console.WriteLine($"Press 's' to create {Constants.DTOs.DTOResources.Stone.Name} resource");
            Console.WriteLine($"Press 'g' to create {Constants.DTOs.DTOResources.Gold.Name} resource");

            string key = Resources.storeKey();

            switch (key)
            {
                case "w":

                    Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Wood.Name);
                    break;

                case "s":

                    Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Stone.Name);
                    break;

                case "g":
                    Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOResources.Gold.Name);
                    break;

                case "d":
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine("That is not a valid option. You will not live to see tomorrow.\n");
                        Task.Delay(50);
                    }
                    break;

                default:
                    CreateItem Item = new CreateItem();
                    Console.WriteLine("Input not recognised...");
                    Item.Create(Storage.ResourcesList);
                    break;
            }
        }
        //TODO: #1a Make use of this override when creating Buildings
        public void Create(List<Building> buildingList) 
            {
            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"You currently have {buildingList.Count} types of Buildings");

            Storage.DisplayResourcesInStorage();
            //TODO: if a resource/building exists, the user should not see an option to create it
            Console.WriteLine($"Press 'm' to build a Mine");

            string key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "m":

                    Constants.Extension_Methods.CreateNewBuilding(Constants.DTOs.DTOBuildings.Mine.Name);
                    break;

                default:
                    CreateItem item = new CreateItem();
                    Console.WriteLine("Input not recognised...");
                    item.Create(Storage.BuildingsList);
                    break;
            }

            SpendResourcesPage.SpendResources();

        }
    }
}
