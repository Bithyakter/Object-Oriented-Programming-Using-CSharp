using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    /*==================================================================================================
     * Polymorphism provides the ability to a class to have multiple implementation with the same name
     * 1. Static/Compile Time - (Method Overloading)     2. Dynamic/Runtime - (Method Overriding)
     * Method Overriding Canbe done by usign Inheritance
     * With method overriding, we can override the method of ParentClass with same method of ChildClass
     
     #Conditions For Method Overriding:
        1.All Method Name should same           2.All the method should be in different class
        3.Method should have same Parameters    4.There should be Inheritance between Class
     ==================================================================================================*/

    public class Employee
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()     //any drived class can override the virtual method
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void PrintFullName()    //In our derived class we override the same method
        {
            Console.WriteLine(FirstName + " " + LastName + "- PartTime");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- FullTime");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public override void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName + "- Temporary");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryEmployee();

            foreach (Employee emp in employees)
            {
                emp.PrintFullName();
            }

            Console.ReadKey();
        }
    }
}
