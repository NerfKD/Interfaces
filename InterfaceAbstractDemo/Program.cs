using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServisAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1992, 9, 6), FirstName = "Kerim", LastName = "Dinçer", NationalityId = "15215361150" });
            Console.ReadLine();
        }
    }


}
