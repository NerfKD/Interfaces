using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public class CustomerCheckManager : ICustomerCheckService
    {

        //Kendi demo servisim.
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
