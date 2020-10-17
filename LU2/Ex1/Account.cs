using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Account
    {
        double mBalance;
        //double Withdraw100(int toWithdraw);

        public Account()
        {
            mBalance = 0.0;
        }

        public Account(double balance)
        {
            mBalance = balance;
        }

        public double Withdraw(int toWithdraw)
        {
            object obj = new object();
            if (mBalance < 0)
            {
                throw new Exception("Negative balance!!!");
            }
            lock (obj)
            {
                if (mBalance >= toWithdraw)
                {
                    Console.WriteLine("Amount before Withdrawal : " + mBalance);
                    Console.WriteLine("Amount to Withdraw       : " + toWithdraw);
                    mBalance -= toWithdraw;
                    Console.WriteLine("Amount after Withdrawal  : " + mBalance);
                    return mBalance;
                }
                else
                {
                    Console.WriteLine("Not enought money! Money in the bank: " + mBalance);
                    return 0; // transaction rejected  
                }
            }
        }

        public double GetBalance()
        {
            return this.mBalance;
        }
    }
}
