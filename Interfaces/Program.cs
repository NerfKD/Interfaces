using System;

namespace Interfaces
{
    class Program
    {
        #region Comments
        //Hepsi inheritance altında ki add içinde işlem yapacaksa Inheritance.
        //Hepsinin ayrı ayrı içinde add i olacak ve farklı işlemler kendi add leri altında olacaksa Interface.
        #endregion
        static void Main(string[] args)
        {
            #region Inheritance
            //Inheritance
            //Property
            Person customer = new Customer();
            customer.Id = 2;
            Console.WriteLine(customer.Id);

            //Method
            PersonManager customerManager = new CustomerManager();
            customerManager.Add();

            //project manager üzerinde dinamik bir yapı için.
            ProjectManager2 projectManager2 = new ProjectManager2();
            projectManager2.Add(customerManager); // --  projectManager2.Add(new CustomerManager()); şeklinde de yazılabilir.

            projectManager2.Add(new AManager()); // yeni bir class eklendiğinde.

            #endregion
            #region Interface
            //Interface
            //Property
            IPerson employee = new Employee();
            employee.Id = 1;
            Console.WriteLine(employee.Id);

            //Method
            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();
            employeeManager.Update();

            //project manager üzerinde dinamik bir yapı için.
            ProjectManager1 projectManager1 = new ProjectManager1();
            projectManager1.Add(employeeManager); // --  projectManager1.Add(new EmployeeManager()); şeklinde de yazılabilir.
            projectManager1.Update(employeeManager); // --  projectManager1.Update(new EmployeeManager()); şeklinde de yazılabilir.

            projectManager1.Add(new BManager()); // yeni bir class eklendiğinde.
            projectManager1.Update(new BManager()); // yeni bir class eklendiğinde.
            #endregion
        }
    }
    #region InheritanceAdd
    //Inheritance - class olur
    //Property
    class Person
    {
        public int Id { get; set; }
    }

    class Customer : Person
    {

    }

    //Method
    class PersonManager
    {
        //implemented operation
        public void Add()
        {
            Console.WriteLine("Eklendi");
        }
    }

    class AManager : PersonManager
    {

    }

    class CustomerManager : PersonManager
    {

    }
    #endregion
    #region InterfaceAdd
    //Interface -- implements - interface olarak yazılır. ":" impelements karşılığına gelir.
    //Interface newlenemez.

    interface IPerson
    {
        int Id { get; set; }
    }

    class Employee : IPerson
    {
        public int Id { get; set; }
    }

    interface IPersonManager
    {
        //implemented operation
        void Add();
        void Update();
    }

    class BManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("B eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("B güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi.");
        }
    }
    #endregion

    #region InheritanceDynamic
    //Inheritance dinamik yapı.
    class ProjectManager2
    {
        public void Add(PersonManager personManager)
        {
            personManager.Add();
        }
    }

    #endregion
    #region InterfaceDynamic
    //Interface dinamik yapı.
    class ProjectManager1
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
        public void Update(IPersonManager personManager)
        {
            personManager.Update();
        }
    }
    #endregion

}
