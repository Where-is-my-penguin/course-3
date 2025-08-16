using System;

namespace SkillBox_3._4 //Игра «Угадай число»
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;
            bool win = false;
            Random hiddenNumber = new Random();

            Console.Write($"Введите число диспозона: ");
            int tryNumber = 1;
            int range = int.Parse(Console.ReadLine());
            int randomValue = hiddenNumber.Next(0, range);
            Console.WriteLine("================================");
            Console.WriteLine("Чтобы закончить напишите: \"exit\"");

            while (win == false)
            {                              
                Console.Write("Введите загаданное число: ");
                string text = Console.ReadLine();
                if (text != "exit")
                {
                    value = int.Parse(text);
                    if (value < randomValue)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }
                    else if (value > randomValue)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }
                    else
                    {
                        Console.WriteLine("=============================");
                        Console.WriteLine($"Вы угадали! Ваши попытки: {tryNumber}");
                        win = true;
                    }
                }
                else
                {
                    Console.WriteLine("================================");
                    Console.WriteLine($"Загаданное число: {randomValue}");
                    break;
                }
                tryNumber++;
            }
            Console.ReadKey();
        }
    }
}
