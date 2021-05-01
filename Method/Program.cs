using System;

namespace Method
{
    class Program
    {
        /*===================================Method===========================================*/
        /*-------------------------------
         * Method are also called function. 
         * Method are useful because it allow us to define our logic once and use it at many places.
         * If two methods having the same name but different parameters then it called method overloading
         
        <Access specifier> <returnType> <methodName>(parameterList)
        {
            //Method Body
        }
         -------------------------------*/
        public static int result = 0;               //Global scope variable

        #region     //Print Full Name with optional parameter

        public static void PrintFullName(string FirstName, string LastName = "Tabassum")       //PrintFullName is Method
                                                                                               //Here FirstName is mandatory parameter,LastName is Optional Parameter (Tabassum)
        {
            Console.WriteLine("Student Full Name: {0} {1}", FirstName, LastName);
        }

        #endregion

        #region     //ProductDetails

        public static void ProductDetails(string ProductName, int ProductPrice, string ProductCategory = "Food")           //Here ProductName,ProductPrice is mandatory Parameter & ProductCategory is Optional Parameter
        {
            Console.WriteLine("ProductName = {0}, ProductPrice = {1}, ProductCategory = {2}", ProductName, ProductPrice, ProductCategory);
        }

        #endregion


        #region     //Method Overloading with Local Scope
        public static void GetValue(int number1, int number2)                //Method
        {
            int TotalNumber = number1 + number2;                              //TotalNumber is Local Scope Variable
            result = TotalNumber;
            Console.WriteLine("{0}+{1}", number1, number2, TotalNumber);
        }

        public static void GetValue(int number1, int number2, int number3)       //Same Method with different parameter    
        {
            int TotalNumber = number1 + number2 + number3;                       //TotalNumber is Local Scope Variable
            result = TotalNumber;
            Console.WriteLine("{0}+{1}+{2}", number1, number2, number3, TotalNumber);
        }

        #endregion

        static void Main(string[] args)
        {
            //print full name
            PrintFullName(FirstName: "Shammi", LastName: "Ahmed");        //Named Arguments
            PrintFullName("Nafiya");

            //Product Details
            ProductDetails(ProductName: "Computer", ProductPrice: 1500, ProductCategory: "Electronics");  //Named Arguments
            ProductDetails(ProductName: "Coffee", ProductPrice: 1200);

            //Method Overloading
            GetValue(80, 20);
            Console.WriteLine("Sum of Two Number: " + result);            // global variable can be accessible

            GetValue(50, 30, 40);
            Console.WriteLine("Sum of Three Number: " + result);           //Global variable can be access from here

            Console.ReadLine();
        }
    }
}

