using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
     class Employee
    {
        int ID;
        int Age;
        string Name;
        string Address;
        

        public Employee()
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS");

            Console.WriteLine("Enter the Employee ID");
            this.ID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee age");
            this.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Employee name");
            this.Name = Console.ReadLine();

            Console.WriteLine("Enter the Employee address:");
            this.Address = Console.ReadLine();
        }

        public Employee(Employee tempObj)       //Copy Constructor
        {
            this.ID = tempObj.ID;
            this.Age = tempObj.Age;
            this.Name = tempObj.Name;
            this.Address = tempObj.Address;
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is:  " + this.ID);
            Console.WriteLine("Employee name is:  " + this.Name);
            Console.WriteLine("Employee age is:  " + this.Age);
            Console.WriteLine("Employee address is:  " + this.Address);
        }
    }
}
