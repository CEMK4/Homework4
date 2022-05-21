using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Задание 1. Случайная матрица
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int col, row;
            Random rand = new Random();
            Console.Write("Введите кол-во строк: ");
            int.TryParse(Console.ReadLine(), out row);
            Console.Write("Введите кол-во столбцов: ");
            int.TryParse(Console.ReadLine(), out col);

            int[,] matr = new int[row, col];
            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    matr[i, j] = rand.Next(128);

            int sum = 0;
            Console.WriteLine("\nПолученная матрица:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{matr[i, j],3} ");
                    sum += matr[i,j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nСумма всех элементов матрицы = {sum}");
        }
    }
}
