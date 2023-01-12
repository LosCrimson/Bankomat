using Bankomat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Repos
{
    public class CardTransactionRepo : CardRepos<CardTransaction>
    {
        public static List<CardTransaction> cardTransactions = new List<CardTransaction>();
    }
}
