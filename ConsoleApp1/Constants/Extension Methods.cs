using ConsoleApp1.Constants.DTOs;
using ConsoleApp1.Events.Classes;
using ConsoleApp1.Events.Interfaces;
using ConsoleApp1.Pages;
using ConsoleApp1.Pages.ResourceFiles;
using ConsoleApp1.Pages.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Constants
{
    internal class Extension_Methods
	{
		public void InputUnrecongnisedMessage() 
			{
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Input not recognised...");
			}

        public string storeKey() => Console.ReadKey().Key.ToString().ToLower();

    }

}