using System;


namespace SkillBox_3._0 //Приложение по определению чётного или нечётного числа
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите любое число: ");
            if (int.Parse(Console.ReadLine()) % 2 == 0)
            {
                Console.WriteLine("Число четное!");
            }
            else
            {
                Console.WriteLine("Число не четное!");
            }
            Console.ReadKey();
        }
    }
}
