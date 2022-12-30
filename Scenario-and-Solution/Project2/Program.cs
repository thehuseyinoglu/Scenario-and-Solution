using Project2.Abstract;
using Project2.Concrete;
using Project2.Entities;
using System;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game= new Game
            {
                Id= 1,
                Name = "mario",
                Price=100
            };
            Campaign campaign = new Campaign
            {
                Id = 1,
                Discount = 20,
                Name = "Yilbasi"
            };

            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "Berkay",
                LastName = "huseyinoglu"
            };


            ISaleService saleManager = new SaleManager();

            saleManager.Sell(gamer, campaign, game);

            





        }
    }
}
