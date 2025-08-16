using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_4._2 //Задание 2. Сложение матриц
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomValue = new Random();

            Console.Write("Введите количество строк в матрице: ");          //Размеры матрицы
            int numberLines = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int numberColumns = int.Parse(Console.ReadLine());

            int[,] matrixA = new int[numberLines, numberColumns];           //Три матрицы с одинаковыми размерами
            int[,] matrixB = new int[numberLines, numberColumns];           
            int[,] matrixC = new int[numberLines, numberColumns];

            Console.WriteLine("=============");                             //Разделение красивой чертой (более менее красивой чернтой)
            Console.WriteLine("Matrix A");
            for (int i = 0; i < numberLines; i++)                           //Создание матрицы А с числами от 0 до 4                              
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    matrixA[i, j] = randomValue.Next(0, 5);
                    Console.Write($"{matrixA[i, j]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("=============");
            Console.WriteLine("Matrix B");
            for (int i = 0; i < numberLines; i++)                           //Создание матрицы В с числами от 0 до 5
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    matrixB[i, j] = randomValue.Next(0, 6);
                    Console.Write($"{matrixB[i, j]} ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("=============");                             //Матрица С - это Матрица А + Матрица В
            Console.WriteLine("Matrix C");
            for (int i = 0; i < numberLines; i++)
            {
                for (int j = 0; j < numberColumns; j++)
                {
                    matrixC[i, j] = matrixA[i, j] + matrixB[i, j];
                    Console.Write($"{matrixC[i, j]} ");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
