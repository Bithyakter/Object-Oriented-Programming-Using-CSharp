using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    /*===============================================================================
        # Method that Same Name of Class Name
        # Don't have return type, so don't return values
        # Access modifier can be used
        # No need to call constructor, It invoked when objects get created
        # It initialize member variables of a Class
        # you can declare more than one constructor in a class
        # Constructor can be Overloaded
     ================================================================================*/

    class Program
    { 
        public Program()        //Constructor
        {
           Console.WriteLine("Hello I am Constructor!");       
        }

        static void Main(string[] args)
        {
            Program obj = new Program();    //The constructor will be called automatically when obj created 

            //Example of Car Constructor
            Car myCar = new Car("Ferrari", 1998);
            Console.WriteLine("Model: " + myCar.carModel);
            Console.WriteLine("Year: " + myCar.carYear);

            Car oMycar = new Car(1987, "Motorola", 4);
            Console.WriteLine("Model: " + oMycar.carModel);
            Console.WriteLine("Year: " + oMycar.carYear);
            Console.WriteLine("Wheels: " + oMycar.carWheels);

            //Example of Copy Constructor
            Console.WriteLine("Example Of Copy Constructor");
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(emp1);
            emp1.GetEmployeeInfo();
            emp2.GetEmployeeInfo();


            Console.ReadLine();
        }
    }
}
