using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise3_2
{
    class Program
    {
        public System.Threading.ThreadPriority Priority { get; set; }
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter numbers of cols: ");
            int cols = int.Parse(Console.ReadLine());

            double[,] array = fillArray(rows, cols);

            Console.WriteLine();
            Console.Write("Enter double num to sum array: ");
            double num = Double.Parse(Console.ReadLine());

            var cores = Environment.ProcessorCount;

            Stopwatch sw = new Stopwatch();

            Thread thread1 = new Thread(() => sumArray(array, rows, cols, num));
            thread1.Name = "ThreadOne";
            thread1.Priority = ThreadPriority.Normal;

            Thread thread2 = new Thread(() => sumArray(array, rows, cols, num));
            thread2.Name = "ThreadTwo";
            thread2.Priority = ThreadPriority.BelowNormal;

            sw.Start();
            thread1.Start();
            thread1.Join();
            sw.Stop();
            Console.WriteLine("Time of threadOne: " + sw.ElapsedMilliseconds);
            Console.WriteLine();
            sw.Reset();

            sw.Start();
            thread2.Start();
            thread2.Join();
            sw.Stop();
            Console.WriteLine("Time of threadTwo: " + sw.ElapsedMilliseconds);
            Console.WriteLine();
        }

        public static double[,] fillArray(int rows, int cols)
        {
            double[,] myArray = new double[rows, cols];

            Random randNum = new Random();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    myArray[row, col] = randNum.NextDouble();
                }
            }
            return myArray;
        }

        public static double[,] sumArray(double[,] array, int rows, int cols, double num)
        {
            double[,] resultArray = new double[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row % 100 == 0 && col % 100 == 0)
                    {
                        Console.WriteLine(Thread.CurrentThread.Name);
                        Console.WriteLine("Row: {0}, Col: {1}", row, col);
                    }
                    resultArray[row, col] = array[row, col] * num;
                }
            }
            return resultArray;
        }
    }
}

