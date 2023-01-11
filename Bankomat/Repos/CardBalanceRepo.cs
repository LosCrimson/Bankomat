using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Repos
{
    public class CardBalanceRepo : CardRepos<CardBalance>
    {
        public static List<CardBalance> cardBalances = new List<CardBalance>
        {
            new CardBalance(CardRepo.CardGuids.ElementAt(0), 26.36),
            new CardBalance(CardRepo.CardGuids.ElementAt(1), 666.30),
            new CardBalance(CardRepo.CardGuids.ElementAt(2), 241896.60),
            new CardBalance(CardRepo.CardGuids.ElementAt(3), 2326.85),
            new CardBalance(CardRepo.CardGuids.ElementAt(4), 266.78),
            new CardBalance(CardRepo.CardGuids.ElementAt(5), 2156.28),
            new CardBalance(CardRepo.CardGuids.ElementAt(6), 8926.09),
            new CardBalance(CardRepo.CardGuids.ElementAt(7), 2356.90),
            new CardBalance(CardRepo.CardGuids.ElementAt(8), 2166.66),
            new CardBalance(CardRepo.CardGuids.ElementAt(9), 1926.15),
        };
    }
}
