using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Shared;

namespace ConsoleApp1.Pages.Shared
{
    internal class CreateItem
    {
        public void Create(List<EntityTypes> entityList, string entityType)
        {
            Console.Clear();
            new ItemInfo().ViewStatus(entityList, entityType);

            switch (entityType)
            {
                case "Building":

                    Console.WriteLine("");
                    Console.WriteLine($"Press 'm' to build a {new DTOBuildings().Mine}");
                    var key = new Extension_Methods().storeKey();
                    switch (key)
                    {
                        case "m":
                            if (MineValidation(Storage.ResourcesList))
                            {
                                CreateEntity(new DTOBuildings().ItemType, new DTOBuildings().Mine, Storage.BuildingsList);
                            }
                            else 
                            { 
                                Console.Clear();   
                                Console.WriteLine("The validation criteria are not met yet."); 
                            }

                            new UserMessages().PressAnyKeyToNavigateToMenu();
                            break;

                        default:
                            var item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.BuildingsList, new DTOBuildings().ItemType);
                            break;
                    }

                    break;

                case "Resource":
                    Console.WriteLine("");
                    if (!entityList.Any(item => item.ItemName == new DTOResources().Wood))
                    {
                        Console.WriteLine($"Press 'w' to build {new DTOResources().Wood}");
                    }

                    if (!entityList.Any(item => item.ItemName == new DTOResources().Stone))
                    {
                        Console.WriteLine($"Press 's' to build {new DTOResources().Stone}");
                    }

                    if (!entityList.Any(item => item.ItemName == new DTOResources().Gold))
                    {
                        Console.WriteLine($"Press 'g' to build {new DTOResources().Gold}");
                    }

                    if (entityList.Count == 3)
                    {
                        Console.WriteLine("You have created all the resources possible");
                        new UserMessages().PressAnyKeyToNavigateToMenu();
                    }

                    key = new Extension_Methods().storeKey();
                    switch (key)
                    {
                        case "w":
                            CreateEntity(new DTOResources().ItemType, new DTOResources().Wood, Storage.ResourcesList);
                            break;

                        case "s":
                            CreateEntity(new DTOResources().ItemType, new DTOResources().Stone, Storage.ResourcesList);
                            break;

                        case "g":
                            CreateEntity(new DTOResources().ItemType, new DTOResources().Gold, Storage.ResourcesList);
                            break;

                        default:
                            var item = new CreateItem();
                            Console.WriteLine("Input not recognised...");
                            item.Create(Storage.ResourcesList, new DTOResources().ItemType);
                            break;
                    }

                    break;
            }
        }

        bool MineValidation(List<EntityTypes> resourceList)
        {
            var wood = resourceList.FirstOrDefault(x => x.ItemName == new DTOResources().Wood);
            if (wood == null) return false;
            if (wood.ItemCounter < 1000) return false;

            wood.ItemCounter -= 1000;
            return true;
        }

        void CreateEntity(string entityType, string entityName, List<EntityTypes> entityList)
        {
            if (entityList.Any(item => item.ItemName == entityName))
            {
                Console.Clear();
                Console.WriteLine($"You already have {entityName}.");
                new UserMessages().PressAnyKeyToNavigateToMenu();
            }
            else
            {
                entityList.Add(new EntityTypes(entityType, entityName));
                Console.Clear();
                Console.WriteLine($"{entityName} has been created!");
                new UserMessages().PressAnyKeyToNavigateToMenu();
            }
        }
    }
}