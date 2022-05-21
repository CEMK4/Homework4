using System;
using System.Linq;

//Задание 2. Наименьший элемент в последовательности
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            Console.Write("Введите длинну последовательности: ");
            int.TryParse(Console.ReadLine(), out length);
            int[] seq = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Введите число: ");
                int.TryParse(Console.ReadLine(), out seq[i]);
            }
            Console.WriteLine($"\nНаименьший элемент последовательности = {seq.Min()}");
        }
    }
}
