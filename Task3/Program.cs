using System;

//Задание 3. Игра «Угадай число» 
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int bound;
            Random rand = new Random();
            Console.Write("Введите максимальное число диапазона: ");
            int.TryParse(Console.ReadLine(), out bound);
            int randNum = rand.Next(bound + 1);
            Console.WriteLine("Попробуйте угадать число.");
            int curNum;
            while (true)
            {
                Console.Write("Введите очередное число: ");
                if (int.TryParse(Console.ReadLine(), out curNum))
                {
                    if (curNum > randNum)
                        Console.WriteLine("Загаданное число меньше введённогo.\n");
                    else if (curNum < randNum)
                        Console.WriteLine("Загаданное число больше введённогo.\n");
                    else
                    {
                        Console.WriteLine("Вы угадали!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine($"\nЗагаданное число - {randNum}");
                    break;
                }
            }
        }
    }
}
