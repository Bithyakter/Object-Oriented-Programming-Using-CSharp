using System;

namespace Inheritance
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlySalary;
    }
    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }


    /*======================================Method Hiding===============================
            *  Use the 'new' keyword to hide a base class members.
            *  Also you can use the 'base' keyword to call the hidden base class members.
     ===================================================================================*/

    //public class FullTimeEmployee : Employee
    //{
    //    public new void PrintFullName()     ///to hide the base class members
    //    {
    //        base.PrintFullName();       //invoked hidden base class members
    //    }
    //}


    public class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee partTime = new PartTimeEmployee();     //For PartTimeEmployee
            partTime.FirstName = "Nafiya";
            partTime.LastName = "Tabassum";
            partTime.PrintFullName();

            FullTimeEmployee fullTime = new FullTimeEmployee();     //For FullTimeEmployee
            fullTime.FirstName = "Shamima";
            fullTime.LastName = "Ahamed";
            fullTime.PrintFullName();

            /* For Method Hiding */
            //((Employee)fullTime).PrintFullName();   //Cast childtype to parenttype and invoked baseclass members
            //Employee emp = new FullTimeEmployee();
            //emp.PrintFullName();

            Console.WriteLine("------------------------------------------");
            ChildClass CClass = new ChildClass();

            Console.ReadKey();
        }
    }
    
    /*=======================================================================*/
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("ParentClass Constructor Called");
        }
        public ParentClass(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class ChildClass : ParentClass
    {
        public ChildClass() : base("Drived Class Contolling ParentClass!")
        {
            Console.WriteLine("ChildClass Constructor Called");
        }
    }



}
