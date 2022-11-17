using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;

namespace ConsoleApp1.Pages
{
    internal class StartUp
    {
        public void Welcome()
        {
            Console.WriteLine("Hello and welcome to the Resource Manager!");
            new UserMessages().PressAnyKeyToNavigateToMenu();   
        }
    }
}
