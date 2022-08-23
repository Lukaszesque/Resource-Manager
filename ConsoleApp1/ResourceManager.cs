using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ResourceManager
    {
        public string ResourceName { get; set; }
        public float ResourceCounter { get; set; }
        public float UpgradeRequiredAmount { get; set; }
        public float UpgradeCounter { get; set; } 
        public float Modifier { get; set;}   
        public static List<string> ?ResourcesList = new List<string>{ };
        public void ShowResources()
        {
            Console.WriteLine($"You now have {ResourceCounter} of {ResourceName}!");
        }
        public void GetResources(int resources) 
            { 
                ResourceCounter+= resources * Modifier;
            Console.WriteLine($"{resources * Modifier} {ResourceName} obtained! You now have {ResourceCounter} of {ResourceName}!");
        }
        public void SpendResources(int amount) 
            { 
                ResourceCounter -= amount;
                UpgradeCounter += amount;
                Console.WriteLine($"You now have {ResourceCounter} of {ResourceName}!");
                
                if (UpgradeCounter >= UpgradeRequiredAmount) 
                {
                    Upgrade();
                }
        }

        public void Upgrade() 
            { 
                Modifier *= 1.1f;
                UpgradeCounter *= 1.2f;
                Console.WriteLine($"{ResourceName} upgraded! Next level will cost {UpgradeCounter} of {ResourceName}");
            }


        public ResourceManager(string resourceName)
        {
            ResourceName = resourceName;
            ResourceCounter = 100;
            UpgradeRequiredAmount = 50;
            Modifier = 1;
            ResourcesList.Add(resourceName);

            Console.WriteLine($"New resource of {resourceName} created");
        }
    }
}
