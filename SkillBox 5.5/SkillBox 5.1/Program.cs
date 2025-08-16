using System;

namespace SkillBox_5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинное предложение: ");
            SplitText(Console.ReadLine());
            Console.ReadKey();
        }

        /// <summary>
        /// принимает строковую переменную, возвращает — массив слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static void SplitText(string text)
        {
            string[] offer = text.Split(' ');
            Delimiter(offer);
        }

        /// <summary>
        /// выводит каждое слово в отдельной строке
        /// </summary>
        /// <param name="array"></param>
        static void Delimiter(string[] array)
        {
            Console.WriteLine("============");
            foreach (string offer in array)
            {
                Console.WriteLine($"{offer}");
            }
        }
    }
}
