using ConsoleApp1.Events.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Events.Classes
{
    internal class Building : IViewStatus
    {
        public string Name { get; set; }
        public float Counter { get; set; }

        public Building(string name)
        {
            Name = name;
            Counter = 0;
        }
    }
}
