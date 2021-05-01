using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /*=================================================================================================
     * Interface is look like a class but it has no implementation, they simply declaration.
     * It cann't have Method Body. 
     * We cann't create an instance of an Interface
     * Class can inherite Multiple interface at the same time
     * Interfaces can inherite from others Interfaces
     Restrictions:
        1.Not allowed to define any fields,not even static fields
        2.Not allowed to define any constructor/desturctor in interafce
        3.Cann't specify any access Modifier, implicitly public
        4.Not allowed to inherite from a  class/structure
     ===================================================================================================*/
     interface ICustomer    //cann't specify any access modifier
    {
        //int ID;       //interface cann't contains field,get an compile time error

        //public void CustomerInfo();     //cann't have access modifier,by default public
        //{
        //    Console.WriteLine(CustomerInfo);    //get an compile time Error
        //}

        void CustomerInfo();    //no need to specify implementation, it's only declaration
    }


    interface ICustomer2
    {
        void Customer2Info();
    }
    public class Customer : ICustomer, ICustomer2   //Multiple Interfaces inherite
    {
        //Need implementation for ICustomer Interface otherwish you will get compile time error

        //public void CustomerInfo(string Name)   //ICustomer doesn't have any signature/parameter
        //{
        //}

        public void CustomerInfo()
        {
            Console.WriteLine("Print interface Customer Info");
        }
        public void Customer2Info()
        {
            Console.WriteLine("Print interface Customer2 Info");
        }
    }

    /* Interfaces can inherite from others Interfaces */
    interface IStudent1
    {
        void Student1();
    }
    interface IStudent2 : IStudent1     //IStudent2 interface can inherite IStudent1 interface
    {
        void Student2();
    }

    public class StudentInfo : IStudent2    //StudentInfo class implementing both of this method
    {
        public void Student1()
        {
            Console.WriteLine("Print Student1");
        }
        public void Student2()
        {
            Console.WriteLine("Print Student2");
        }
    }

    /*==================Explicit interfaces implementation====================*/
    interface IEmployee1
    {
        void Employee();
    }
    interface IEmployee2
    {
        void Employee();
    }

    public class EmployeeInfo : IEmployee1, IEmployee2
    {
        public void Employee()    //Default interface method. One is deafult and other 1 is Explicitly Implement
        {
            Console.WriteLine("Default Interface Method");
        }
        void IEmployee1.Employee()
        {
            Console.WriteLine("IEmployee1 Interface method implementation");
        }
        void IEmployee2.Employee()
        {
            Console.WriteLine("IEmployee2 Interface method implementation");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //ICustomer ics = new ICustomer();    //Interface cann't create an instance 

            Customer cs = new Customer();
            cs.CustomerInfo();

            ICustomer ics = new Customer();    //interface reference variable can point to a derived class object
            ics.CustomerInfo();

            StudentInfo std = new StudentInfo();
            std.Student1();
            std.Student2();

            //Explicit interfaces
            Console.WriteLine("\n=====Explicit Interface Implementation=====\n");

            EmployeeInfo emp = new EmployeeInfo();
            //emp.EmployeeInfo();     //It's not possible in explicitly interface,get an compile time error
            emp.Employee();
            ((IEmployee1)emp).Employee();  

            ((IEmployee2)emp).Employee();

            IEmployee1 emp1 = new EmployeeInfo(); //either do this or Type cast
            IEmployee2 emp2 = new EmployeeInfo();
            emp1.Employee();
            emp2.Employee();

            Console.ReadLine(); 
        }
    }
}
