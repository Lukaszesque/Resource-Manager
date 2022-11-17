using ConsoleApp1.Constants;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.ResourceFiles
{
    internal class ResourceStatusPage
    {
        public void ResourceStatus(string resourceType)
        {
            Console.Clear();
            new ItemInfo().ViewStatus(Storage.ResourcesList, resourceType);
            new UserMessages().PressAnyKeyToNavigateToMenu();
        }


    }
}
