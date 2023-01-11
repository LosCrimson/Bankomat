using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Models
{
    public class CardPassword : CardsData
    {
        private string _password;
        public string Password { get { return _password; } set { _password = value; } }
        public CardPassword(Guid guid, string password) 
        {
            Guid = guid;
            _password = password;
        }
    }
}
