using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBank
{
    public class BankAccount
    {

        public BankAccount(double amount)
        {
            _balance = amount;
        }

        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
            Console.WriteLine("Deposit succesful.");
        }

        public void Withdraw(double amount)
        { 
            _balance -= amount;
            Console.WriteLine("Withdraw succesful.");
        }

        public double GetBalance()
        { 
            return _balance;
        }











































    }
    
}
