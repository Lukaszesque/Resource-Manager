using ConsoleApp1.Pages;
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
                ResourceManagerPage.ResourceManager();
            }
            else
            {
                Storage.DisplayResourcesInStorage();
                Console.WriteLine("Please select which Resource to add to:");
                Console.WriteLine("");

                for (int i = 0; i < Storage.ResourcesList.Count; i++)
                {
                    Console.WriteLine($"Press {i} to add to {Storage.ResourcesList[i].ResourceName}"
                        
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

                //Sets the resources to the amount added multiplied by the modifier
                Storage.ResourcesList[key].ResourceCounter += amount * Storage.ResourcesList[key].Modifier;

                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine($"The {amount} of {Storage.ResourcesList[key].ResourceName} is multiplied by the Modifier value of {Storage.ResourcesList[key].Modifier}. This result in a total increase of {amount * Storage.ResourcesList[key].Modifier}");
                Console.WriteLine($"You now have {Storage.ResourcesList[key].ResourceCounter} of {Storage.ResourcesList[key].ResourceName}");
                MenuPage.Menu();
            }
        }

        public static void CreateNewResource(string resourceName) 
            {
            //Creates an instance of a resource, but only if one does not already exist
            //TODO: handle null references exceptions
            //TODO: refactor as per Pitambars code
            bool alreadyExists = false;
            foreach (var item in Storage.ResourcesList)
            {
                if (item.ResourceName == resourceName)
                {
                    alreadyExists = true;
                }
            }

            if (alreadyExists)
            {
                Console.WriteLine("");
                Console.WriteLine($"You already have {resourceName}.");
            }
            else
            {
                var newResource = new ResourceManager(resourceName);
                Storage.ResourcesList.Add(newResource);
            }

            MenuPage.Menu();
        }

    }
}
