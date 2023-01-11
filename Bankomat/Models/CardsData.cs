using Bankomat.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public abstract class CardsData : ICardsData
    {
        private Guid _guid;
        public Guid Guid { get { return _guid; } set { _guid = value; } }

    }
}
