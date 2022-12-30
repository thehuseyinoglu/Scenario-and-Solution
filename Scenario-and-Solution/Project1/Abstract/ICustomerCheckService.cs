using Project1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Abstract
{
    public interface ICustomerCheckService
    {
         bool CheckIfRealPerson(Customer customer);
    }
}
