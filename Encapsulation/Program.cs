using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();

            //myAccount.AccountBalance = 100000;  //won't be compile, get an Error bcoz AccountBalance is Private

            myAccount.SetBalance(100000);
            myAccount.GetBalance();

            //Using Properties
            myAccount.Balance = 100000;
            Console.WriteLine("Your Account Balance is: " + myAccount.Balance);

            Console.ReadLine();

        }
    }
}
