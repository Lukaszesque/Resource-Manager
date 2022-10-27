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

            if (Storage.ResourcesList.Any(item => item.ResourceName == resourceName)) 
                {
                    Console.WriteLine("");
                    Console.WriteLine($"You already have {resourceName}.");
                }
            else 
                {
                Storage.ResourcesList.Add(new ResourceManager(resourceName));
                }

            MenuPage.Menu();
        }

        //TODO: Refactor this to be inclusive of Buildings as well. Float / Int does not matter as you need to convert to string
        public static void ViewResourceStatus() 
            {

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"You currently have {Storage.ResourcesList.Count} type of Resources in your collection");
            Console.WriteLine($"The resources that you have are as following:");
            foreach (var item in Storage.ResourcesList)
            {
                Console.WriteLine($"Resource: " + item.ResourceName);
                Console.WriteLine($"Amount: " + item.ResourceCounter);
                Console.WriteLine();
            }
        }

        public static void CreateNewBuilding(string buildingName) 
        { 
            //retreive the building from the list. If none is obtained then the variable  will be Null
            var builingObject = Storage.BuildingsList.FirstOrDefault(building => building.Name == buildingName);

            if (builingObject == null)
            {
                Storage.BuildingsList.Add(new Building(buildingName));
            }
            else 
            {
                Console.WriteLine("");
                Console.WriteLine($"You already have {builingObject.Name} constructed. It's level is {builingObject.Level}");
            }

            
        }
    }
}

