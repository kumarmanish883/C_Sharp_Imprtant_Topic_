using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    /*How to achive Encapsulation
     1.Declare the variable of the class as Private.(Data Hiding).
     2.Provide public.setter and getter method to modify and view the variables values.
     
     */

    class Account
    {
         int accountBalance = 1000;

        //Set method to value lai set grna !!!!
        public void SetBalance(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("You cannot pass negative value");
            }
            else
            {
                accountBalance = amount;
            }
            
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is :" + accountBalance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.SetBalance(-1540);
            acc.GetBalance();
            Console.ReadLine();

        }
    }
}
