using Capstone;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Capstone
{
    public class Purchase
    {

        public decimal CurrentBalance { get; set; }
        public DateTime DateTime { get; set; }

        public StuffedAnimals ProductSelected { get; set; } //needs to indicate a position set by the user, and reference a stuffedAnimal(hypothetically through a dictionary?)
        public decimal UserMoney { get; set; }
        public Purchase(decimal currentBalance, DateTime dateTime)
        {
            CurrentBalance = currentBalance;
            DateTime = dateTime;
        }





        //METHODS
        public decimal FeedMoney(decimal moneyAdded)
        { CurrentBalance += moneyAdded; return CurrentBalance; } //function for user to add money

        public decimal FinishTransaction() //part of the purchase flow, that dispenses change, sets balance to 0, sends user to beginning of process
        {
            decimal changeToDispense = CurrentBalance - ProductSelected.Price;
            CurrentBalance = 0;
            return changeToDispense;
        }

        public void RecordFeedMoney(Purchase purchaseToRecord)
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            string TransactionFile = "Log.txt";
            string fullPath = Path.Combine(CurrentDirectory, TransactionFile);
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(DateTime.Now + " FEEDMONEY " + "Money deposited/spent/given: " + UserMoney + " New Balance: " + CurrentBalance);
            }
        }

        public void RecordTransaction(Purchase purchaseToRecord)
        {
            string CurrentDirectory = Environment.CurrentDirectory;
            string TransactionFile = "Log.txt";
            string fullPath = Path.Combine(CurrentDirectory, TransactionFile);
            using (StreamWriter sw = new StreamWriter(fullPath, true))
            {
                sw.WriteLine(DateTime.Now + " " + purchaseToRecord.ProductSelected.Name + " Money deposited/spent/given: " + purchaseToRecord.UserMoney + " New Balance: " + CurrentBalance);
            }

        }


        public decimal MakeChange(Purchase currentBalance)
        {
            decimal change = 0;
            change = currentBalance.CurrentBalance;
            return change;

        }

        public void ConvertChange(decimal change)

        {
            decimal quarters=0 ;
            decimal dimes=0 ;
            decimal nickels=0 ;

            while (change >= .25M)
            {
                quarters = Math.Truncate((change/.25m));
                change -= quarters * .25M;

            }
            while (change >= .10M)
            {
                dimes = Math.Truncate((change / .10M));
                change -= dimes * .10M;
            }
            while (change >= .05M)
            {
                nickels = Math.Truncate((change / .05M));
                change -= nickels * .05M;
            }
            Console.WriteLine($"Quarters: {quarters} Dimes: {dimes} Nickels:{nickels}");
        }
    }
}
