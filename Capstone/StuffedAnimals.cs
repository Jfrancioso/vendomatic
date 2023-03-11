using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class StuffedAnimals // the items for sale, parent class of each species
    {
        public string Species { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Position { get; set; }

        public int CurrentStock { get; set; } = 5; // default set to 5, because this is max inventory , the only StuffedAnimals property that will change at all 

        public string Message { get; set; }

        public StuffedAnimals(string position, string name, decimal price, string species) // our constructor
        {
            Species = species;
            Name = name;
            Price = price;
            Position = position;
            
        }     
    }

}
