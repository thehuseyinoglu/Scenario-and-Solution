using Project2.Abstract;
using Project2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Concrete
{
    public class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + "adli oyuncu eklendi");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + "silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine();
        }
    }
}
