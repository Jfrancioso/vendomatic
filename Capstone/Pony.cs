using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Pony : StuffedAnimals
    {
        public string message { get; set; } = "Neigh, Neigh, Yay";


        public Pony(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }


        
    }
}
