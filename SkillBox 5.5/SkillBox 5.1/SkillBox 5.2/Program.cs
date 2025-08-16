using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillBox_5._2 //Задание 2. Перестановка слов в предложении
{
    class Program //Копипаста...
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длинное предложение: ");
            SplitText(Console.ReadLine());
            Console.ReadKey();
        }

        /// <summary>
        /// Принимает строковую переменную, возвращает — массив слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static void SplitText(string text)
        {
            string[] offer = text.Split(' ');
            Delimiter(offer);
            ReverseOffer(offer);                                        //Тут добавил строчку
        }

        /// <summary>
        /// Выводит каждое слово в отдельной строке
        /// </summary>
        /// <param name="array"></param>
        static void Delimiter(string[] array)
        {
            Console.WriteLine("============");
            foreach (string offer in array)
            {
                Console.WriteLine($"{offer}");
            }
        } //...Копипаста

        /// <summary>
        /// Меняет слова местами (в обратной последовательности).
        /// </summary>
        /// <param name="arrayOffer"></param>
        static void ReverseOffer(string[] arrayOffer)
        {
            Console.WriteLine("============");
            Array.Reverse(arrayOffer);
            foreach (string offer in arrayOffer)
            {
                Console.WriteLine($"{offer}");
            }
        }
    }
}
