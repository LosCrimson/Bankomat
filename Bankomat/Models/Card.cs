using Bankomat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public class Card : ICardsData
    {
        private Guid _guid;
        private Guid _cardPassword;
        private Guid _cardBalance;
        private Guid _transactions;

        public Guid Guid { get { return _guid; } set { _guid = value; } }
        public Guid CardPassword { get { return _cardPassword; } set { _cardPassword = value; } }
        public Guid CardBalance { get { return _cardBalance; } set { _cardBalance = value; } }
        public Guid Transactions { get { return _transactions; } set { _transactions = value; } }

        public Card(Guid guid) 
        {
            _guid = guid;
            _cardPassword = guid;
            _cardBalance = guid;
            _transactions = guid;

        }
    }
}
