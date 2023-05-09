using Bankomat.Models;
using Bankomat.Repos;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.Interfaces;


namespace Bankomat.Services
{
    public class CardService
    {
        // Guid internalGuid;
        UIService ui = new UIService();
        public void IsCardCorrect()
        {
            CardRepo.CardGuids.ForEach(card => { if (card.ToString() == ui.RequestCardGUID()) 
                { 
                    TryPassword(ui.RequestPassword(), card);
                   // internalGuid = card;
                }; });
        }
        //public List<CardTransaction> GetLastFiveTransactions() 
        //{

        //}
        public void TryPassword(string password, Guid guid)
        {
            bool fail = false;
            int i = 0;
            CardRepos<CardPassword> parent = new CardPasswordRepo();
            do
            {
                if(i < 2)
                {
                    string s = parent.Retrieve(guid, CardPasswordRepo.cardPasswords).Password;
                    if (password == s)
                    { ui.MainMenu(); }
                    else 
                    { 
                        i++; 
                        Console.WriteLine("Wrong password"); 
                        password = ui.RequestPassword();
                    }
                }
                else 
                { 
                    fail = true; 
                    Console.WriteLine("Wrong password three times");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            while (fail == false);
        }

        //public void CheckBalance()
        //{
        //    double money;
        //    ui.SeeBalance(money = CardBalanceRepo.cardBalances.Single(balance => balance.Guid == internalGuid).Balance); 
        //}

    }
}
