using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class Duck : StuffedAnimals
    {
   public string message { get; set; } = "Quack, Quack, Splash";




        public Duck(string position, string name, decimal price, string species) : base(position, name, price, species)
        {        }

    }
}
