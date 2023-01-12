using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public class CardBalance : CardsData
    {
        private double _balance;

        public double Balance { get { return _balance; } set { _balance = value; } }

        public CardBalance(Guid guid, double balance) 
        {
            Guid = guid;
            _balance = balance;
        }
    }
}
