using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array
            /*======================
                Array is a Collection of similar data type
                Syntax:
                    datatype[] name of arrayvariable
            ======================*/

            //string[] cars = { "BMW", "Ferrari", "Maruti", "Ford" };

            string[] cars = new string[4] { "BMW", "Ferrari", "Maruti", "Ford" }; //can declare Array Size

            Console.WriteLine(cars[3]);     //can access array elements with index value

            //you can access multiple array elements with help of for loop & foreach
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            #endregion

            #region List
            /*======================
                List is same as Array used to store multiple values in a single variable.
                Syntax:
                    list<datatype> nameOfList = new list<datatype>();
            ======================*/
            List<string> vehicles = new List<string>();
            vehicles.Add("Ferrari");
            vehicles.Add("BMW");
            vehicles.Add("Maruti");
            vehicles.Add("Ford");

            for (int i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine(vehicles[i]);
            }

            foreach (string vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
            #endregion

            Console.WriteLine("Single Dimension Array Sample");
            // Single dimensional array  
            string[] friends = new string[] 
              {
                    "Mst Bithy",
                    "Shammi",
                    "Nafiya Nitu",
                    "Suparna Sarker",
                    "Rafin Radi"
              };

            // Read array items using foreach loop  
            foreach (string name in friends)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Multi-Dimension Array Sample");
            string[,] string2DArray = new string[2, 2]
            {
                {"Nitu", "Trisha"},

                {"Shuvo",  "Bithy"}
            };

            foreach (string str in string2DArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Jagged Array Sample");

            int[][] intJaggedArray3 = {
                new int[] { 2, 12},
                new int[] {14, 14, 24, 34},
                new int[] {6, 16, 26, 36, 46, 56 }
             };

            // Loop through all itesm of a jagged array  
            for (int i = 0; i < intJaggedArray3.Length; i++)
            {
                Console.Write($"Element({i}): ");
                for (int j = 0; j < intJaggedArray3[i].Length; j++)
                {
                    Console.Write($"{intJaggedArray3[i][j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------");


            Console.ReadLine();

        }
    }
}
