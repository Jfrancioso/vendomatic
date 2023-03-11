using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Capstone
{
    class Menu
    {
        static void Main(string[] args)
        {
            //creating vending machine and dictionary to fill our vending machine        
            Dictionary<string, StuffedAnimals> LoadedDictionary = new Dictionary<string, StuffedAnimals>();
            CuteCoVendingMachine loadedVendingMachine = new CuteCoVendingMachine(LoadedDictionary);
            //calling method to fill our dictionary/vendingmachine with our products
            LoadedDictionary = loadedVendingMachine.LoadInventory(loadedVendingMachine.StuffedAnimalsDictionary);

            Purchase currentPurchase = new Purchase(0, DateTime.Now);
            //creating a purchase object to  reference and use later

            //Creating main user interface
            //while (true)
            
            
              while(true)  {

                Console.WriteLine("Welcome to the CuteCo Vendomatic800, where cuteness is our currency and you will leave with a new best friend! :)");
                Console.WriteLine();   
                Console.WriteLine("(1) To see what CrazyCuteCreatures we have in stock, select 1 for Display");
                Console.WriteLine("(2) To bring your new bestie home, select 2 for Purchasing");
                Console.WriteLine("(3) To leave all these sweeties behind and continue your drab existence alone, press 3 to Exit");
                Console.WriteLine();
                    string userInputString = Console.ReadLine();


                    if (userInputString == "1") //Display selection
                    {

                        loadedVendingMachine.DisplayCurrentInventory(LoadedDictionary);
                    }
                    else if (userInputString == "2") // Purchase Flow menu
                    {// asks what action user wants to take, then reads their input and stores it in "userPurchaseSelection" variable

                        Console.WriteLine("Select 1 to add money");
                        Console.WriteLine("Select 2 to pick your pal");
                        Console.WriteLine("Select 3 to Finish transaction");
                        string userPurchaseSelection = Console.ReadLine();

                        if (userPurchaseSelection == "1") //FeedMoney function
                        {//asks user how much money they would like to add then adds that amount to the CurrentBalance property

                            Console.WriteLine("Money Money Money please. Cash rules everything around me, CREAM.");
                            Console.WriteLine("Please type how much money you are adding.");
                            string userMoneyInput = Console.ReadLine();
                            decimal userMoneyToAdd = decimal.Parse(userMoneyInput);
                            currentPurchase.UserMoney = userMoneyToAdd;
                            currentPurchase.FeedMoney(userMoneyToAdd);
                            Console.WriteLine($"Current Money Provided:{currentPurchase.CurrentBalance}");
                            Console.WriteLine();
                            currentPurchase.RecordFeedMoney(currentPurchase);

                           
                    }
                        else if (userPurchaseSelection == "2") //select product function
                        {//displays current inventory of our vending machine and 
                            loadedVendingMachine.DisplayCurrentInventory(LoadedDictionary);

                            Console.WriteLine("Who are you taking home today?");//Insert SelectProduct function

                            string productSelectionInput = Console.ReadLine();

                            if (loadedVendingMachine.StuffedAnimalsDictionary.ContainsKey(productSelectionInput)) //checks that product exists
                            {
                                StuffedAnimals productSelected = loadedVendingMachine.StuffedAnimalsDictionary[productSelectionInput];
                                currentPurchase.ProductSelected = productSelected;
                                Console.WriteLine($"You have selected {productSelected.Name}");

                                if (productSelected.Price <= currentPurchase.CurrentBalance)
                            { //dispense method, affects tock and current balance
                                loadedVendingMachine.DispenseProduct(productSelected, currentPurchase);
                                loadedVendingMachine.WriteMessage(productSelected);
                                Console.WriteLine(loadedVendingMachine.AnimalMessage);
                                currentPurchase.RecordTransaction(currentPurchase);
                           
                            }
                                else 
                                    {
                                        Console.WriteLine("Please add more money to get selected product"); 
                                        Console.WriteLine();
                                    }
                            }
                            else
                            {
                                Console.WriteLine("You have entered an invalid product code");
                                Console.WriteLine();
                            }
                        }
                        else if (userPurchaseSelection == "3")
                    {// FinishTransaction function
                        currentPurchase.ConvertChange(currentPurchase.CurrentBalance);
                        Console.WriteLine();



                    }
                            Console.WriteLine();
                            Console.WriteLine("Thank you for using CuteCo to brighten your day and bring meaning to your sad little life!");
                            

                    }

                    else if (userInputString == "3") // Exit button
                    { break; }
                   
                    else 
                    {
                    Console.WriteLine();
                    Console.WriteLine("Please enter a valid selection.");
                    Console.WriteLine();
                    } // wrong input handling

                }















        }

    }
}


