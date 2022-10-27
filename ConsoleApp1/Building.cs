using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Building
    {
        public string Name {get; set;}
        public int Level { get; set;}

        public Building(string name)
        {
            Name = name;
            Level = 0;
        }
    }
}
