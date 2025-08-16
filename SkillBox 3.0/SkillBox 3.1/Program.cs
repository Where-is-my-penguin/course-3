using System;

namespace SkillBox_3._1 //Программа подсчёта суммы карт в игре «21»
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.Write("Здравствуйте, введите количество карт: ");
            int numberCards = int.Parse(Console.ReadLine());

            Console.WriteLine("==========");
            Console.WriteLine("Валет = J");
            Console.WriteLine("Дама = Q");
            Console.WriteLine("Король = K");
            Console.WriteLine("Туз = T");
            Console.WriteLine("==========");

            for (int i = 0; i < numberCards; i++)
            {                             
                Console.Write($"Введите наминал {i + 1} карты: ");
                //int cards = int.Parse(Console.ReadLine());
                string card = Console.ReadLine();

                switch (card)
                {
                    case "J":
                        sum += 10;
                        break;
                    case "Q":
                        sum += 10;
                        break;
                    case "K":
                        sum += 10;
                        break;
                    case "T":
                        sum += 10;
                        break;
                    default:
                        sum += int.Parse(card);
                        break;
                }
            }
            Console.WriteLine("==================");
            Console.WriteLine($"Количество карт: {numberCards}");
            Console.WriteLine($"Сумма очков: {sum}");

            Console.ReadKey();
        } 
    }
}