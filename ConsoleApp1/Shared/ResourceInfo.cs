using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages;

namespace ConsoleApp1.Shared
{
    internal class ItemInfo
    {
        internal void ViewStatus(List<EntityTypes> entityList, string entityType)
        {
            if (entityList.Count == 0)
            {
                Console.WriteLine($"You do not have any {entityType}s yet.");
            }
            else
            {
                Console.WriteLine($"You currently have {entityList.Count} type of {entityType} in your collection");
                Console.WriteLine($"The resources that you have are as following:");
            }

            foreach (var item in entityList)
            {
                Console.WriteLine("");
                Console.WriteLine($"Resource: " + item.ItemName);
                Console.WriteLine($"Level: " + item.ItemLevel);
                Console.Write($"Amount: {item.ItemCounter}");
                Console.WriteLine();
            }
        }
        internal void GetResources()
        {
            //TODO: The resource should be modified by the Building level.
            Console.Clear();

            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Wood))
            {
                Console.WriteLine("Press 'w' to add more Wood");
            }
            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Stone))
            {
                Console.WriteLine("Press 's' to add more Stone");
            }
            if (Storage.ResourcesList.Any(item => item.ItemName == new DTOResources().Gold))
            {
                Console.WriteLine("Press 'g' to add more Gold");
            }

            string key = new Extension_Methods().storeKey();

            switch (key)
            {
                case KeyInputs.WoodKey:
                    AddToItemCounter(new DTOResources().Wood, KeyInputs.WoodKey);
                    break;

                case KeyInputs.StoneKey:
                    AddToItemCounter(new DTOResources().Stone, KeyInputs.StoneKey);
                    break;

                case KeyInputs.GoldKey:
                    AddToItemCounter(new DTOResources().Gold, KeyInputs.GoldKey);
                    break;
            }

        }

        private void AddToItemCounter(string resourceName, string keyInput)
        {
            var objectRef = Storage.ResourcesList.FirstOrDefault(i => i.ItemName == resourceName);
            float addedAmount = 100;

            //TODO: # 1 Implement leveling up of the Mine so that this can be tested
            if (resourceName == new DTOResources().Stone && Storage.BuildingsList.Any(x => x.ItemName == "Stone")) 
                {  
                    addedAmount = BuildingMultiplier(addedAmount, Storage.BuildingsList.FirstOrDefault(i => i.ItemName == "Stone").ItemLevel);
                } 

            if (objectRef?.ItemLevel > 0) addedAmount *= objectRef.ItemLevel;
            if (objectRef != null) objectRef.ItemCounter += addedAmount;
            Console.Clear();
            Console.WriteLine($"{addedAmount} added to {resourceName}. You now have {objectRef?.ItemCounter} {resourceName}.");

            //The player can add more resources or navigate back to the menu
            Console.WriteLine($"Press '{keyInput}' to continue adding {resourceName}");
            Console.WriteLine("Press any other key to navigate back to the Menu");
            string key2 = new Extension_Methods().storeKey();

            if (key2 == keyInput)
            {
                AddToItemCounter(resourceName, keyInput);
            }
            else
            {
                new MenuPage().Menu();
            }
        }

        private float BuildingMultiplier(double valueToMultiply, int buildingLevel) 
            {   
            //Buildings increase the output by value = value^(buildingLevel / 10)
                return (float)Math.Pow(valueToMultiply, Convert.ToDouble(buildingLevel) / 10);
            }
    }
}
