using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows: ");
            long rows = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of cols: ");
            long cols = long.Parse(Console.ReadLine());

            long[,] firstMatrix = new long[rows, cols];
            long[,] secondMatrix = new long[rows, cols];

            firstMatrix = fillMatrix(rows, cols);
            secondMatrix = fillMatrix(rows, cols);

            var cores = Environment.ProcessorCount;

            Stopwatch sw = new Stopwatch();

            sw.Start();
            multiplyMatrix(firstMatrix, rows, cols);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            sw.Reset();

            sw.Start();
            parallelmultiplyMatrix(firstMatrix, rows, cols);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            Console.WriteLine("Press enter to finish");
            Console.ReadLine();
        }

        private static void parallelmultiplyMatrix(long[,] firstMatrix, long rows, long cols)
        {
            Parallel.For(0, rows, (row) =>
            {
                Parallel.For(0, cols, (col) =>
                {
                    firstMatrix[row, col] *= 99;
                });
            });
        }

        private static void multiplyMatrix(long[,] firstMatrix, long rows, long cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    firstMatrix[row, col] *= 99;
                }
            }
        }

        private static void parallelmultiplyTwoMatrices(long[,] firstMatrix, long[,] secondMatrix, long rows, long cols)
        {
            long[,] matrix = new long[rows, cols];

            Parallel.For(0, rows, i => {
                Parallel.For(0, cols, j => {
                    matrix[i, j] = 0;
                    Parallel.For(0, cols, k => {
                        matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    });
                });
            });
        }

        private static void multiplyTwoMatrices(long[,] firstMatrix, long[,] secondMatrix, long rows, long cols)
        {
            long[,] matrix = new long[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 0;
                    for (int k = 0; k < cols; k++)
                    {
                        matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                }
            }
        }

        private static long[,] fillMatrix(long rows, long cols)
        {
            long[,] matrix = new long[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = row * col;
                }
            }
            return matrix;
        }
    }
}
