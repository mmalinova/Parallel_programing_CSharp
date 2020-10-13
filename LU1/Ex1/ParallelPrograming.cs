using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ParallelPrograming
    {
        public static void Main() {

            var cores = Environment.ProcessorCount;

            Stopwatch sw = new Stopwatch();

            int[] dataItems = new int[100000000];
            double[] resultItem = new double[100000000];

            for (int i = 0; i < dataItems.Length; i++)
            {
                dataItems[i] = i;
            }

            sw.Start();
            for (int i = 0; i < dataItems.Length; i++)
            {
                resultItem[i] = Math.Pow(dataItems[i], 2);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            Parallel.For (0, dataItems.Length, i => {
                resultItem[i] = Math.Pow(dataItems[i], 2);
            });
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }
    }
}
