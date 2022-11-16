using ConsoleApp1.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    public class EntityTypes : IItemDetails
    {
        public string ItemType { get; set; }
        public string ItemName { get; set; }
        public int ItemLevel { get; set; }
        public float ItemCounter { get; set; }

        public EntityTypes(string itemType, string itemName) 
            { 
                this.ItemType = itemType;
                this.ItemName = itemName;
                this.ItemLevel = 1;
                this.ItemCounter = 0;
            }
    }
}
