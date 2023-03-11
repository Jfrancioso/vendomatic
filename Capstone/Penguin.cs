using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Penguin : StuffedAnimals
    {
        public string message { get; set; } = "Squawk, Squawk, Whee";


        public Penguin(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }


        

        
               
    }
    
   
}
