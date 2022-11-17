using ConsoleApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constants
{
    internal class UserMessages
    {
        internal void Separator() { Console.WriteLine("---------------------------------------------------------"); }
        internal void ChooseFromTheBelow() {
            Console.WriteLine("");
            Console.WriteLine("Please choose from the options below:"); 
        }
        internal void PressAnyKeyToNavigateToMenu()
        {
            Console.WriteLine("");
            Console.WriteLine($"Press any key to navigate back to the menu.");
            string key = new Extension_Methods().storeKey();

            switch (key)
            {
                default:
                    Console.WriteLine();
                    Console.WriteLine("Navigating to the Menu.");
                    new MenuPage().Menu();
                    break;
            }



        }
    }
}

