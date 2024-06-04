using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк в будующей матрице: ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в будующей матрице: ");
            int col = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, col];

            Random r = new Random();
            int sum = 0; 
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = r.Next(10);
                    sum += matrix[i, j];
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма всех элементов матрицы равна: {sum}");
        }
    }
}
