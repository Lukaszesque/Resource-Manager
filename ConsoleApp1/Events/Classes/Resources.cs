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
        public string Name { get; set; }
        public float Counter { get; set; }
        public float UpgradeRequiredAmount { get; set; }
        public float UpgradeCounter { get; set; }
        public float Modifier { get; set; }
        public void ShowResources()
        {
            Console.WriteLine($"You now have {Counter} of {Name}!");
        }

        public void SpendResources(int amount)
        {
            Counter -= amount;
            UpgradeCounter += amount;
            Console.WriteLine($"You now have {Counter} of {Name}!");

            if (UpgradeCounter >= UpgradeRequiredAmount)
            {
                Upgrade();
            }
        }

        public void Upgrade()
        {
            Modifier *= 1.1f;
            UpgradeCounter *= 1.2f;
            Console.WriteLine($"{Name} upgraded! Next level will cost {UpgradeCounter} of {Name}");
        }

        public static string storeKey() => Console.ReadKey().Key.ToString().ToLower();
        public Resources(string resourceName)
        {
            Name = resourceName;
            Counter = 100;
            UpgradeRequiredAmount = 50;
            Modifier = 1;

            Console.WriteLine($"\n \nNew resource of {resourceName} created");
        }
    }


}
