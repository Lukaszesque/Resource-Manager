using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    internal class Resources : IViewStatus
    {
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public float ItemCounter { get; set; }
        public float UpgradeRequiredAmount { get; set; }
        public float UpgradeCounter { get; set; }
        public float Modifier { get; set; }
        public void ShowResources()
        {
            Console.WriteLine($"You now have {ItemCounter} of {ItemName}!");
        }

        public void SpendResources(int amount)
        {
            ItemCounter -= amount;
            UpgradeCounter += amount;
            Console.WriteLine($"You now have {ItemCounter} of {ItemName}!");

            if (UpgradeCounter >= UpgradeRequiredAmount)
            {
                Upgrade();
            }
        }

        public void Upgrade()
        {
            Modifier *= 1.1f;
            UpgradeCounter *= 1.2f;
            Console.WriteLine($"{ItemName} upgraded! Next level will cost {UpgradeCounter} of {ItemName}");
        }

        public static string storeKey() => Console.ReadKey().Key.ToString().ToLower();
        public Resources(string resourceName)
        {
            ItemName = resourceName;
            ItemCounter = 100;
            UpgradeRequiredAmount = 50;
            Modifier = 1;

            Console.WriteLine($"\n \nNew resource of {resourceName} created");
        }
    }


}
