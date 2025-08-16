using System;
using System.IO;

namespace Delete
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"Practical work.txt";

            CreateFile();
            Console.WriteLine("введём 1 — вывести данные на экран;");
            Console.WriteLine("введём 2 — заполнить данные и добавить новую запись в конец файла.");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a != 2)
            {
                CreateFile();
                Console.WriteLine(" ");
                Console.WriteLine("Вывод файла:");
                Console.WriteLine(" ");
                Console.WriteLine(File.ReadAllText(@"Practical work.txt"));
            }
            else
            {
                CreateInfo();
            }
            Console.ReadKey();
            
        }
        static void CreateInfo()                                                 //Создаём текст
        {
            Repository rep = new Repository();

            DateTime timeNow = DateTime.Now;

            Console.Write("Введите Ф.И.О.: ");
            string fullname = Console.ReadLine();

            Console.Write("Введите возраст: ");
            byte age = byte.Parse(Console.ReadLine());

            Console.Write("Введите рост(см): ");
            ushort height = ushort.Parse(Console.ReadLine());

            Console.Write("Введите дату рождения(2002,01,26): ");
            DateTime dateBirth = DateTime.ParseExact(Console.ReadLine(), "yyyy,MM,dd",null);

            Console.Write("Введите место проживания: ");
            string placeBirth = Console.ReadLine();

            Worker worker = new Worker()
            {
                TimeNow = timeNow,
                FIO = fullname,
                Age = age,
                Height = height,
                DateBirth = dateBirth,
                PlaceBirth = placeBirth
            };

            rep.AddWorker(worker);
        }
        static void CreateFile()                            //Создаём фыайл если не создан
        {
            if (!File.Exists(@"Practical work.txt"))
            {
                File.Create(@"Practical work.txt");
            }
        }
    }

}