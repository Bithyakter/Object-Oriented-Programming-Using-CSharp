using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01 Calling For BankAccount Class

            var account = new BankAccount("Bithy", 500000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            #endregion

            #region 02 Calling For GradePoint

            GradePoint obj = new GradePoint(0.5f, 5);
            Console.WriteLine("Grade = {0}, point = {1}", obj.Grade, obj.Point);

            #endregion

            #region 03 Calling For Employee Class

            Employee emp = new Employee(1263995, "Bithy");           //instant class
            Console.WriteLine("ID = {0}, Name = {1}", emp.ID, emp.Name);

            #endregion
            

            Console.ReadLine();
        }
    }
}

