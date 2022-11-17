using ConsoleApp1.Constants;
using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages.Shared;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.ResourceFiles
{

    internal class BuildingMenu
    {
        public void MenuPage()
        {

            //Notify user of what resources he has
            Console.Clear();
            Console.WriteLine("You are at the Buildings Menu.");
            Console.WriteLine("");
            Console.WriteLine("Press 'b' to see your Buildings");
            Console.WriteLine("Press 'c' to create Buildings");
            Console.WriteLine("Press 'm' to navigate back to the Main Menu");

            var key = new Extension_Methods().storeKey();

            switch (key)
            {
                case "b":
                    new ItemInfo().ViewStatus(Storage.BuildingsList, new DTOBuildings().ItemType);
                    new UserMessages().PressAnyKeyToNavigateToMenu();
                    break;

                case "c":
                    new CreateItem().Create(Storage.BuildingsList, new DTOBuildings().ItemType);
                    break;

                case "m":
                    new MenuPage().Menu();
                    break;

                default:
                    new Extension_Methods().InputUnrecongnisedMessage();
                    MenuPage();
                    break;
            }


        }
    }
}
