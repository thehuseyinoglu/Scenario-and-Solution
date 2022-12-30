using Project2.Abstract;
using Project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Concrete
{
    public class SaleManager : ISaleService
    {
        
        public void Sell(Gamer gamer, Campaign campaign,Game game)
        {
            int tmpPrice = (game.Price * campaign.Discount) /100;
            double a = game.Price - tmpPrice;

            Console.WriteLine(gamer.FirstName + gamer.LastName + " adli kullanici" + campaign.Name + " kampanyasindan yararlanarak" +game.Name + " oyununu" + a +  " fiyatina satin aldi");
        }
    }
}
