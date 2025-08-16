using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_4._1 //Задание 1. Случайная матрица
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumArray = 0;
            Random randomValue = new Random();

            Console.Write("Введите количество строк в матрице: ");
            int numberLines = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int numberColumns = int.Parse(Console.ReadLine());

            int[,] array = new int[numberLines, numberColumns];

            for (int i = 0; i < numberLines; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    array[i, j] = randomValue.Next(0, 10);
                    Console.Write($"{array[i, j]} ");
                    sumArray += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма матрицы = {sumArray}");
            Console.ReadKey();
        }
    }
}
