﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    //TODO: With using constants this should be redundant
    public class EntityNames
    {
        public string Type { get; set; }
        public string Name { get; set; }

        public EntityNames(string entityType)
        {
            Type = entityType;
        }
    }
}
