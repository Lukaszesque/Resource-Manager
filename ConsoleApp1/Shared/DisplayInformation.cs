using ConsoleApp1.Events.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Pages.Shared
{
    internal class DisplayInformation
    {
        public void DisplayResourcesInStorage(List<EntityTypes> entityList)
        {
            if (entityList.Count > 0)
            {
                string x = string.Empty;

                foreach (var item in entityList)
                {
                    x = item.ItemName + ", ";
                }
                Console.WriteLine();
                Console.WriteLine($"Your resources are: {x}");
            }
            else
            {
                Console.WriteLine("You do not have any resources yet.");
            }
        }
    }
}
