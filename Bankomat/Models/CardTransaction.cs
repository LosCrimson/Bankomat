using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public class CardTransaction : CardsData
    {
        private double _transaction;
        private DateTime _transactionDate;

        public double Transaction { get { return _transaction; } set { _transaction = value; } }
        public DateTime TransactionDate { get { return _transactionDate; } }

        public CardTransaction(Guid guid, double transaction) 
        { 
            Guid = guid;
            _transactionDate = DateTime.Now;
            _transaction = transaction;
        }
    }
}
