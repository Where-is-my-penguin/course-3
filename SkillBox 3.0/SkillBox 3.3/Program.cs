using System;

namespace SkillBox_3._3 //Наименьший элемент в последовательности
{
    class Program
    {
        static void Main()
        {
            int minValue = int.MaxValue; //minValue = int.MaxValue выглядит странно)

            Console.Write("Введите длинну последовательности: ");
            int lenght = int.Parse(Console.ReadLine());

            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Введите число:");
                int value = int.Parse(Console.ReadLine());
                if (value < minValue)
                {
                    minValue = value;
                }
            }
            Console.WriteLine("========================");
            Console.WriteLine($"Минимальное число:{minValue}");

            Console.ReadKey();
        }
    }
}
