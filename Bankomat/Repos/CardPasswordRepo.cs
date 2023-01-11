using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Repos
{
    public class CardPasswordRepo : CardRepos<CardPassword>
    {
        public static List<CardPassword> cardPasswords= new List<CardPassword>
        {
            new CardPassword(CardRepo.CardGuids.ElementAt(0), "pants0"),
            new CardPassword(CardRepo.CardGuids.ElementAt(1), "pants1"),
            new CardPassword(CardRepo.CardGuids.ElementAt(2), "pants2"),
            new CardPassword(CardRepo.CardGuids.ElementAt(3), "pants3"),
            new CardPassword(CardRepo.CardGuids.ElementAt(4), "pants4"),
            new CardPassword(CardRepo.CardGuids.ElementAt(5), "pants5"),
            new CardPassword(CardRepo.CardGuids.ElementAt(6), "pants6"),
            new CardPassword(CardRepo.CardGuids.ElementAt(7), "pants7"),
            new CardPassword(CardRepo.CardGuids.ElementAt(8), "pants8"),
            new CardPassword(CardRepo.CardGuids.ElementAt(9), "pants9"),
        };
    }
}
