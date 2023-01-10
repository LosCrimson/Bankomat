using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Services
{
    public class UIService
    {

        public string RequestCardGUID()
        {
            Console.WriteLine("Please enter card GUID: ");
            string gUID = Console.ReadLine();
            return gUID;
        }

        public string RequestPassword()
        {
            Console.WriteLine("Please enter card Password: ");
            string password = Console.ReadLine();
            return password;
        }

        public void SeeBalance(double moneyInBank) 
        {
            Console.WriteLine("Balance: " + moneyInBank + "eu");
        }

        public void LastFiveTransacions(List<Transaction> lastFiveTransactions) 
        {
            int i = 0;
            Console.WriteLine("These are the last five transactions:");
            lastFiveTransactions.ForEach(p => Console.WriteLine($"{++i}. {p}eu"));
        }

        public double TakeOutMoney()
        {
            Console.WriteLine("How much money you want to take out?");
            double takeOutAmmount = Double.Parse(Console.ReadLine());
            return takeOutAmmount;
        }

        public static ActionTypes GetActionTypes()
        {
            do
            {
                Console.WriteLine("Pick an option: ");
                Console.WriteLine("[1] Check Balance.");
                Console.WriteLine("[2] Last five transactions.");
                Console.WriteLine("[3] Takeout money.");
                Console.WriteLine("[4] EXIT");

                string menuChoice = Console.ReadLine();

                switch(menuChoice) 
                {
                    case "1": case "CHECK":
                        return ActionTypes.CHECK;
                    case "2": case "LAST":
                        return ActionTypes.LAST;
                    case "3": case "TAEKOUT":
                        return ActionTypes.TAKEOUT;
                    case "4": case "EXIT":
                        return ActionTypes.EXIT;
                    default:
                        Console.WriteLine("Incorrect input");
                        break;
                }
            }
            while(true);
        }

        public void MainMenu()
        {
            while (true)
            {
                switch (UIService.GetActionTypes())
                {
                    case ActionTypes.CHECK:
                        SeeBalance(25.63);
                        break;
                    case ActionTypes.LAST:
                        
                        break;
                    case ActionTypes.TAKEOUT:
                        
                        break;
                    case ActionTypes.EXIT:
                        return;
                }
            }
        }

    }
}
