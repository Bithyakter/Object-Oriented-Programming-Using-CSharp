using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address("G-13, Sec-3", "Noida", "UP");
            Employee e1 = new Employee(1, "Sonoo", a1);
            e1.GetEmployeeInfo();


            Console.ReadLine();
        }
    }
}
