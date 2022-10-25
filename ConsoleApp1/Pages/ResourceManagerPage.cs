using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1.Pages
{
    internal class ResourceManagerPage
    {
        public static void ResourceManager()
        {
            Console.WriteLine($"");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"You currently have {Storage.ResourcesList.Count} Types of resources");

            Storage.DisplayResourcesInStorage();

            Console.WriteLine($"Press 'w' to create {Constants.DTOs.DTOResources.Wood.Name} resource");
            Console.WriteLine("Press 's' to create Stone resource");
            Console.WriteLine("Press 'g' to create Gold resource");

            ResourceManager newResource;

            string key = ConsoleApp1.ResourceManager.storeKey();

            switch (key)
            {
                //Create an instance of a resource, but only if one does not already exist
                case "w":
                    bool alreadyExists = false;
                    foreach (var item in Storage.ResourcesList)
                    {
                        if (item.ResourceName == Constants.DTOs.DTOResources.Wood.Name) 
                            { 
                                alreadyExists = true;
                            }
                    }
                   
                    if (!alreadyExists) 
                        {
                            newResource = new ResourceManager(Constants.DTOs.DTOResources.Wood.Name);
                            Storage.ResourcesList.Add(newResource);
                        }
                    else 
                        { 
                            Console.WriteLine($"You already have {Constants.DTOs.DTOResources.Wood.Name}.");
                        }
                    
                    MenuPage.Menu();
                    break;

                    //TODO: ensure only one instance can be created at a given time. Use a method to make it less wet.

                case "s":

                    newResource = new ResourceManager(Constants.DTOs.DTOResources.Stone.Name);
                    Storage.ResourcesList.Add(newResource);

                    MenuPage.Menu();
                    break;

                case "g":
                    Console.WriteLine("Not yet implemented :D");
                    MenuPage.Menu();
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
                    ResourceManager();
                    break;

            }




        }
    }
}
