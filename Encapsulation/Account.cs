using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Account
    {
        private int AccountBalance = 50000;

        //To Access this AccountBalance, Provide public setter and getter method to modify & view the variable values

        public void SetBalance(int amount)
        {
            AccountBalance = amount;

            //you can control this setter method(If needed)
            if (amount > 0)
            {
                Console.WriteLine("You can't pass Negative Value!");
            }
            else
            {
                AccountBalance = amount;
            }
        }

        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is: " + AccountBalance);
        }

        #region Encapsulation Using Properties
        public int Balance
        {
            set 
            {
                AccountBalance = value;
            }
            get 
            { 
                return AccountBalance; 
            }
        }
        #endregion


    }
}

