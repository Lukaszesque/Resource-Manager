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
            Console.WriteLine($"You currently have {Storage.programStorage.ResourcesList.Count} Types of resources");

            if (Storage.programStorage.ResourcesList.Count > 0)
            {
                string x = string.Empty;

                foreach (var item in Storage.programStorage.ResourcesList)
                {
                    x = item.ResourceName + ", ";
                }
                Console.WriteLine($"Your resources are: {x}");
            }

            Console.WriteLine("Press 'w' to create Wood resource");
            Console.WriteLine("Press 's' to create Stone resource");
            Console.WriteLine("Press 'g' to create Gold resource");

            ResourceManager newResource;

            string key = ConsoleApp1.ResourceManager.storeKey();

            switch (key)
            {
                case "w":
                    newResource = new ResourceManager("Wood");
                    Storage.programStorage.ResourcesList.Add(newResource);
                    MenuPage.Menu();
                    break;

                case "s":
                    Console.WriteLine("Not yet implemented :D");
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
