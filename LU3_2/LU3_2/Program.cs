using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LU3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array dimension: ");
            int dimension = int.Parse(Console.ReadLine());

            double[] array = new double[dimension];

            Console.Write("Enter double num to multiply: ");
            double num = Double.Parse(Console.ReadLine());

            int processorCount = Environment.ProcessorCount;  //запис на броя на процесорите

            Console.WriteLine("The number of processors " +
               "on this computer is {0}.",
             Environment.ProcessorCount);

            Task[] tasks = new Task[processorCount];
            for (int i = 0; i < processorCount; i++)
            {
                tasks[i] = new Task(() => multiplyArray(array, num));                 //създаване на нишките
                //tasks[i] = Task.Factory.StartNew(() => multiplyArray(array, num)); //създаване и стартиране на нишките
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i].Start();   //този код се изпълнява ако нишките не са били стартирани
            }
            
            Task.WaitAll(tasks);   //изчакване на нишките
        }

        private static void multiplyArray(double[] array, double num)
        {
            for (int i = 0; i < array.Length; i++) {
                array[i] *= num;
            }
            Console.WriteLine("Task = {0}, Thread = {1}", Task.CurrentId
                        , Thread.CurrentThread.ManagedThreadId);
        }
    }
}
