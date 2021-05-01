using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    /*===========================================================================
   Access Modifiers in C# are the keywords used to define the visibility of a class property or method.
   C# has 5 Access Modifier keywords:
       1. public: Public class is visible in the current and referencing assembly.
       2. private: Visible inside current class.
       3. protected: Visible inside current and derived class.
       4. Internal: Visible inside containing assembly.
       5. Internal protected: Visible inside containing assembly and descendent of the current class.

     * Classes will never be private or protected
     * By default Class is Internal
     * By default Method is Private
     ===========================================================================*/

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();      //create an Objcet myCar
            myCar.Model = "Ferrari";    //won't compile for Private Modifier
            myCar.Color = "Black";
            myCar.Price = 5000000;

            myCar.PrintCarInformation();
        }
    }

    //#region /*======================Private Modifier===================*/
    //class Car 
    //{
    //    private string Model;
    //    private string Color;
    //    private int Price;

    //    private void PrintCarInformation()        //
    //    {
    //        Console.WriteLine("Model:" + Model);
    //        Console.WriteLine("Model:" + Color);
    //        Console.WriteLine("Model:" + Price);

    //        Console.ReadLine();
    //    }

    //    static void Main(string[] args)
    //    {
    //        Car myCar = new Car();      //create an Objcet myCar
    //        myCar.Model = "Ferrari";
    //        myCar.Color = "Black";
    //        myCar.Price = 5000000;

    //        myCar.PrintCarInformation();
    //    }     
    //}
    //#endregion

    #region /*======================Public Modifier===================*/
    class Car
    {
        public string Model;
        public string Color;
        public int Price;

        public void PrintCarInformation()
        {
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Model:" + Color);
            Console.WriteLine("Model:" + Price);

            Console.ReadLine();
        }

    }
    #endregion
}
