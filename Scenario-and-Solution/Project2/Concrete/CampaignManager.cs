using Project2.Abstract;
using Project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi") ;
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("Kampanya GUNCELLENDI");
        }
    }
}
