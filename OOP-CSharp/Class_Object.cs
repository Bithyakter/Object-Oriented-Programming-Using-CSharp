using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{

    #region 01 BankAccount
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        private static int AccountNumber = 123456789;

        public BankAccount(string name, decimal initialBalance)        //Constructor
        {
            this.Owner = name;
            this.Balance = initialBalance;

            this.Number = AccountNumber.ToString();
            AccountNumber++;
        }
    }
    #endregion

    #region 02 GradePoint
    class GradePoint
        {
            
            public float Grade;         //property declare but not initialize
            public int Point;

            //constructor
            public GradePoint()          //default constructor without parameter
            {
                this.Grade = 5;         //properties initialize in constructor
                this.Point = 2;
            }

            public GradePoint(float _grade, int _point)      //with parameter
            {
                Grade = _grade;
                Point = _point;
            }
 
        }
    #endregion

    #region 03 Employee Class
    public class Employee          //Class
    {
        public int ID;             //property declare but not initialize
        public String Name;


        public Employee(int ID, String Name)        //Constructor Method
        {
            this.ID = ID;                           //property initialize  in constructor
            this.Name = Name;

        }
    }
    #endregion
}
