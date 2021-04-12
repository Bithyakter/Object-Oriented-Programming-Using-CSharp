using System;

namespace Inheritance
{
    /*=====================================================================================================
     * Inheritance is a process of inheriting the properties and behaviour of existing class into New class.
     
    SYNTAX :
        class <Parent Class>
            {
                //variables or Method
            }
        class <child class>:<parent class>
            {
                ///variables or Method
            }
       =======================================================================================================*/
    public class Car    //Parent or Base Class
    {
        public string Model;
        public string Color;
        public int Price;

        public void PrintCarInfo()
        {
            Console.WriteLine("Car Model: "+ Model);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Price: " + Price);
        }
    }

    public class Toyota:Car     //Single Inheritance
    {
        public int Speed;

        public void PrintSpeed()
        {
            Console.WriteLine("Speed: "+Speed);
        }
    }

    public class Ferrari: Car      //Hierarchical Inheritance
    {
        public int Wheel;
        public int MakeYear;

        public void PrintFerrari()
        {
            Console.WriteLine("Wheel: "+Wheel);
            Console.WriteLine("Making Year: " + MakeYear);
        }
    }

    //Child or Drived class
    public class Maruti : Toyota      //Multilevel Inheritance
    {
        public float mileage;

        public void PrintMileage()
        {
            Console.WriteLine("Mileage: " + mileage);
        }

        //static void Main(string[] args)
        //{
        //    Maruti myCar = new Maruti();
        //    myCar.Model = "Toy XI";
        //    myCar.Color = "Black";
        //    myCar.Price = 3000000;
        //    myCar.mileage = 21.5f;
        //    myCar.Speed = 80;
        //    //myCar.Wheel = 3;    //Cann't inherite Ferrari class properties

        //    myCar.PrintCarInfo();
        //    myCar.PrintMileage();
        //    myCar.PrintSpeed();

        //    Console.ReadKey();
        //}
    }
}
