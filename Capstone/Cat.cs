using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Capstone
{
    public class Cat : StuffedAnimals
    {
        public string message { get; set; } = "Meow, Meow, Meow";
    
    
        public Cat(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }

        
    }
}
