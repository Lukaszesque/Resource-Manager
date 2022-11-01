﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Events.Classes;

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
                    ResourceManager();
                    break;

            }




        }
    }
}
