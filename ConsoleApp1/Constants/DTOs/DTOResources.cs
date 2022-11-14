using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Events.Classes;

namespace ConsoleApp1.Constants.DTOs
{
    public class DTOResources
    {
        public static EntityNames Wood = new EntityNames(entityType: "Resource") 
        {    
            Name = "Wood"
        };
        public static EntityNames Stone = new EntityNames(entityType: "Resource")
        { 
            Name = "Stone"
        };

        public static EntityNames Gold = new EntityNames(entityType: "Resource") 
        { 
            Name = "Gold"
        };
        

    }
}
