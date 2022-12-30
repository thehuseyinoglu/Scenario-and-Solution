using Project1.Abstract;
using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Concrete
{
    // Save methodu interface ile alinip ayri ayri kodlabilirdi ama senaryoda save meyhodu iki firma icinde tipa tip ayni varsayilacak.
    public class StarbucksCustomerManager:BaseCustomerManager // ICustomerCheckService interfacesini implement edebiliriz (1. kullanim)
    {
       private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }


           
        }

        //private void CheckIfRealPerson(Customer customer)
        //{
        //   //Butun kodlar burada yazilabilir.
        //   //Fakat Nero`da ayni seyi isterse? || interface ability - operasyon siniflandirmasi
        //}
    }
}
