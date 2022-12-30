using Project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Abstract
{
    internal interface ISaleService
    {
         void Sell(Gamer gamer , Campaign campaign, Game game);

    }
}
