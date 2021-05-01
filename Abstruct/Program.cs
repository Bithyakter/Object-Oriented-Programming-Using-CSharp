using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstruct
{
    /*=================================================================================================
     Data abstraction is the process of hiding certain details and showing only essential information to the user.
     Abstraction can be achieved with either abstract classes or interfaces.

     * An abstract class is a special class we can't be instantiated.
     * An abstract keyword is used to create abstract classes.
     * We can use an abstract class as a base class only.
     
     Abstract Method:
     * An abstract method is a method without any method body. 
     * can only be used in an abstract class
     
     Contents:
        1. An abstract class may contains abstract members,property,event
        2. An abstract class can only be a base class
        3. A non-abstract class can inherite from an abstract class but must provide implementation
        4. If the class doesn't wish implementation,then the class has to be marked as abstract.
        5. To provide the implementation, have to use the override keyword.
        6. An abstract class cann't be sealed.
        7. Cann't create an object.
        8. Abstract class cann't support multiple inheritances
        9. An abstract class can inherit from a class and one or more interfaces.  
     ================================================================================================*/

    public abstract class Customer
    {
        public abstract void Print();   //The method cann't have implementation 

        public void PrintMethod()
        {
            Console.WriteLine("PrintMethod");   //abstract class may contains abstract members but not mandatory
        }
    }

    //public abstract sealed class CustomerSealed   //abstract class cann't be use as a sealed class
    //{
    //}

    //public abstract class Man : Customer
    //{
    //    //class has to be marked as abstract.
    //}
    public class Man : Customer 
    {
        public override void Print()    //For implementation, use the override keyword.
        {
            Console.WriteLine("Print Abstract Method");     //must be need implementation
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer();    //cann't create an instance of an abstract class

            Man m = new Man();
            m.Print();

            Customer C = new Man();     //abstract class reference variable can point to the derived class object
            C.Print();


            Console.ReadLine();
        }
    }
}

