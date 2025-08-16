using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Exists(@"C:\Test\Practical work.txt");                         //Создание файла
            CreateInfo();

            string text = File.ReadAllText(@"C:\Test\Practical work.txt");      //Читаем файл
            Console.WriteLine(text);
            Console.ReadKey();
        }
        static void CreateInfo()                                              //Создаём текст
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.AppendLine();
            string[] info = new string[7];
            Console.Write($"Введите ID: ");
            info[0] = Console.ReadLine();
            DateTime timeNow = DateTime.Now;
            Console.WriteLine($"Дата и время добавление записи: {timeNow}");
            info[1] = timeNow.ToString();
            Console.Write($"Введите Ф.И.О.: ");
            info[2] = Console.ReadLine();
            Console.Write($"Введите возраст: ");
            info[3] = Console.ReadLine();
            Console.Write($"Введите рост(см): ");
            info[4] = Console.ReadLine();
            Console.Write($"Введите дату рождения: ");
            info[5] = Console.ReadLine();
            Console.Write($"Введите место рождения: ");
            info[6] = Console.ReadLine();
            foreach(string add in info)
            {
                Console.WriteLine(info);
            }

            File.WriteAllLines(@"C:\Test\Practical work.txt", info);
        }
    }
}
