using Project1.Abstract;
using Project1.Concrete;
using Project1.Entities;
using System;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
           BaseCustomerManager customerManager= new NeroCustomerManager() ;
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1998,7,16), FirstName="Berkay",LastName="Huseyinoglu", NationalityId="123123123132" });
            
        }
    }
}
