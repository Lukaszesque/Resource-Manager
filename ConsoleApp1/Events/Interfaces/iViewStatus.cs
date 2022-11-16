using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Interfaces
{
    interface IItemDetails
    { 
        string ItemType { get; set; }
        string ItemName { get; set;}
        float ItemCounter { get; set;}
    }
}
