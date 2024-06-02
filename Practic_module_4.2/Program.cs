using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic_module_4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение двух матриц");

            int[,] matrix1 = new int[5, 5];
            int[,] matrix2 = new int[5, 5];
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix1[i, j] = rand.Next(10);
                    Console.Write($"{matrix1[i, j]} ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
            for (int i = 0;i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix2[i, j] = rand.Next(10);
                    Console.Write($"{matrix2[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Сумма двух матриц ");
            int[,] matrix3 = new int[5, 5];
            for (int i = 0; ; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    matrix3[i, j] = matrix1[i, j] + matrix2[i, j];
                    Console.Write($"{matrix3[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
