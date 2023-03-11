using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone
{
    public class CuteCoVendingMachine
    {


       public Dictionary<string, StuffedAnimals> StuffedAnimalsDictionary = new Dictionary<string, StuffedAnimals>();
       public CuteCoVendingMachine(Dictionary<string, StuffedAnimals> stuffedAnimalsDictionary) //lowercase is the input that CuteCo takes, uppercase is what we are working with
        {
            StuffedAnimalsDictionary = stuffedAnimalsDictionary;
        }
       public string AnimalMessage { get; set; }
        //method that displays the unique message of each stuffed animal based on the species
        public void WriteMessage(StuffedAnimals Species)
        {
            if (Species.Species == "Duck") { AnimalMessage = "Quack, Quack, Splash"; }
            else if (Species.Species == "Pony") { AnimalMessage = "Neigh, Neigh, Yay"; }
            else if (Species.Species == "Cat") { AnimalMessage = "Meow, Meow, Meow"; }
            else if (Species.Species == "Penguin") { AnimalMessage = "Squawk, Squawk, Whee"; }
            

        }

        //METHODS
        //load inventory method fills our "vending machine"(dictionary) with all of the stuffed animals that we are selling with a stock of 5
        public Dictionary<string, StuffedAnimals> LoadInventory(Dictionary<string, StuffedAnimals > stuffedAnimalsDictionary)
        {

            Duck Yellow = new Duck("A1", "Yellow Duck", 0.90M, "Duck");
            Duck Cube = new Duck("A2", "Cube Duck", 2.50M, "Duck");
            Duck Beach = new Duck("A3", "Beach Duck", 1.50M, "Duck");
            Duck Bat = new Duck("A4", "Bat Duck", 2.00M, "Duck");

            Penguin Emperor = new Penguin("B1", "Emperor Penguin", 2.80M, "Penguin");
            Penguin Macaroni = new Penguin("B2", "Macaroni Penguin", 2.25M, "Penguin");
            Penguin Rockhopper = new Penguin("B3", "Rockhopper Penguin", 1.50M, "Penguin");
            Penguin Galapagos = new Penguin("B4", "Galapagos Penguin", 1.25M, "Penguin");

            Cat Black = new Cat("C1", "Black Cat", 2.25M, "Cat");
            Cat White = new Cat("C2", "White Cat", 2.50M, "Cat");
            Cat Tabby = new Cat("C3", "Tabby Cat", 2.50M, "Cat");
            Cat Calico = new Cat("C4", "Calico Cat", 3.55M, "Cat");

            Pony Unicorn = new Pony("D1", "Unicorn Pony", 1.95M, "Pony");
            Pony Pegasus = new Pony("D2", "Pegasus Pony", 1.85M, "Pony");
            Pony Horse = new Pony("D3", "Horse", 0.90M, "Pony");
            Pony Rainbow = new Pony("D4", "Rainbow Horse", 1.35M, "Pony");

            StuffedAnimalsDictionary["A1"] = Yellow;
            StuffedAnimalsDictionary["A2"] = Cube;
            StuffedAnimalsDictionary["A3"] = Beach;
            StuffedAnimalsDictionary["A4"] = Bat;

            StuffedAnimalsDictionary["B1"] = Emperor;
            StuffedAnimalsDictionary["B2"] = Macaroni;
            StuffedAnimalsDictionary["B3"] = Rockhopper;
            StuffedAnimalsDictionary["B4"] = Galapagos;

            StuffedAnimalsDictionary["C1"] = Black;
            StuffedAnimalsDictionary["C2"] = White;
            StuffedAnimalsDictionary["C3"] = Tabby;
            StuffedAnimalsDictionary["C4"] = Calico;

            StuffedAnimalsDictionary["D1"] = Unicorn;
            StuffedAnimalsDictionary["D2"] = Pegasus;
            StuffedAnimalsDictionary["D3"] = Horse;
            StuffedAnimalsDictionary["D4"] = Rainbow;

            return stuffedAnimalsDictionary;   
        }

        public void DisplayCurrentInventory(Dictionary<string,StuffedAnimals> test )//displays current inventory
        {
            foreach (KeyValuePair<string, StuffedAnimals> kvp in test)
            {
                if (kvp.Value.CurrentStock == 0)
                { Console.WriteLine(kvp.Key + "  :  " + kvp.Value.Name + " Price: " + kvp.Value.Price + " Current Stock: " + "Out of Stock"); }
                Console.WriteLine(kvp.Key + "  :  " + kvp.Value.Name + " Price: " + kvp.Value.Price + " Current Stock: " + kvp.Value.CurrentStock);
                
            }
            Console.WriteLine();
        }
        //method that decreases current stock of selected stuffed animal subtracts cost of stuffed animal from currrent balance and displays messages to user what they chose and how much money is left
        public void DispenseProduct(StuffedAnimals BeingAdopted, Purchase OngoingPurchase)
        {
            BeingAdopted.CurrentStock--;
            OngoingPurchase.CurrentBalance -= BeingAdopted.Price;
            Console.WriteLine($"You are going home with {BeingAdopted.Name} , Lucky you!");
            Console.WriteLine($"Money left over: {OngoingPurchase.CurrentBalance}");
            Console.WriteLine();
        }


    }
    

}
