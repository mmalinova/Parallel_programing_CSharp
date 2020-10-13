using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        /*static void Main(string[] args)
        {
            int[][] myJaggedArray = {
                                        new int[] {5, 7, 2},
                                        new int[] {10, 20, 40},
                                        new int[] {3, 25}
                                    };

            int[][,] jaggedOfMulti = new int[2][,];
            jaggedOfMulti[0] = new int[,] { {5, 15}, {125, 206}};
            jaggedOfMulti[1] = new int[,] { {3, 4, 5}, {7, 8, 9} };

            Console.WriteLine("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of cols: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");

            matrix = fillMatrix(rows, cols);

            printMatrix(matrix, rows, cols);


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();


        }

        private static void printMatrix(int[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] fillMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write("matrix[{0}, {1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
         */
    }
}
