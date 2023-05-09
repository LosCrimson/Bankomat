using Bankomat.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = new UIService();
            var card = new CardService();
            card.IsCardCorrect();
            i.RequestCardGUID();
            i.MainMenu();
        }
    }
}
