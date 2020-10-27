using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LU3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// use an Action delegate and named method
            Task task1 = new Task(new Action(printMessage));
            // use an anonymous delegate
            Task task2 = new Task(delegate { printMessage() });
            // use a lambda expression and a named method
            Task task3 = new Task(() => printMessage());
            // use a lambda expression and an anonymous method
            Task task4 = new Task(() => { printMessage() });

           // Launch the tasks
           t1.Start();
           t2.Start();
           t3.Start();
           t4.Start();

           // Construct a started task
           Task t2 = Task.Factory.StartNew(() => printMessage());

           // Construct a started task using Task.Run.
           Task t3 = Task.Run(() => printMessage());
             * */

            TaskParallelismSimpleExample();

            Console.WriteLine();
        }

        private static void TaskParallelismSimpleExample()
        {
            //Construct a started task
            Task t1 = Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("Task ParalellismSimpleExample, Task = {0}, Thread = {1}", Task.CurrentId
                        , Thread.CurrentThread.ManagedThreadId);
                });

            Console.WriteLine("t1 has been launched. Task = {0}, Thread = {1}", Task.CurrentId
                        , Thread.CurrentThread.ManagedThreadId);
            //Wait for the task to finish
            t1.Wait();

            //Construct a started task using Task.Run
            Task t2 = Task.Run(
                () =>
                {
                    Console.WriteLine("t2 has been launched. Task = {0}, Thread = {1}", Task.CurrentId
                        , Thread.CurrentThread.ManagedThreadId);
                });
            //Wait for the task to finish
            t2.Wait();
        }
    }
}
