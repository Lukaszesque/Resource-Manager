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
        CreateItem Item = new CreateItem();
        //TODO: Implement a shared method for creating things like buildings or resources
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

            string key = Events.Classes.Resources.storeKey();

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
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("That is not a valid option. You will not live to see tomorrow.\n");
                        Task.Delay(50);
                    }
                    break;

                default:
                    Console.WriteLine("Input not recognised...");
                    CreateItem item = new CreateItem();
                    item.Create(Storage.ResourcesList);
                    break;
            }
        }

        public void Create(List<Building> buildingList) 
            {
            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"You currently have {buildingList.Count} types of Buildings");

            Storage.DisplayResourcesInStorage();
            //TODO: if a resource exists, the user should not see an option to create it
            Console.WriteLine($"Press 'm' to build a Mine");

            string key = Events.Classes.Resources.storeKey();

            switch (key)
            {
                case "m":

                    Constants.Extension_Methods.CreateNewResource(Constants.DTOs.DTOBuildings.Mine.Name);
                    break;

                case "d":
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine("That is not a valid option. You will not live to see tomorrow.\n");
                        Task.Delay(50);
                    }
                    break;

                default:
                    Console.WriteLine("Input not recognised...");
                    CreateItem item = new CreateItem();
                    item.Create(Storage.ResourcesList);
                    break;
            }

        }
    }
}
