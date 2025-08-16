using System;

namespace SkillBox_3._2 //Проверка простого числа
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boolValue = false;
            
            Console.Write("Введите целое число: ");
            int value = int.Parse(Console.ReadLine());

            int i = 2; 
            while (i <= value - 1)
            {
                if (value % i == 0)
                {
                    boolValue = true;                    
                }
                i++;
            }

            if (boolValue)
            {
                Console.Write("был найден делитель, число не может считаться простым");
            }
            else
            {
                Console.Write($"Число {value} простое");
            }           
            Console.ReadKey();
        }
    }
}
