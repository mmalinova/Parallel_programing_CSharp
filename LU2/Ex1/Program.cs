using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        public static Account account = new Account();
        static void Main(string[] args)
        {
            double amount = 0.0;

            Console.Write("Enter amount: ");
            amount = Double.Parse(Console.ReadLine());
            account = new Account(amount);

            Console.WriteLine();

            Thread thread1 = new Thread(() => DoTask());
            thread1.Name = "ThreadOne";
            //Console.WriteLine("Amount: {0}", account.GetBalance());

            Thread thread2 = new Thread(() => DoTask());
            thread2.Name = "ThreadTwo";
            //Console.WriteLine("Amount: {0}", account.GetBalance());

            thread1.Start();

            thread1.Join();
            thread2.Start();
        }

        static void DoTask()
        {
            account.Withdraw(100);
        }
    }
}

