using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delete
{
    class Repository
    {
        //public Worker[] GetAllWorkers()
        //{
        //    // здесь происходит чтение из файла
        //    // и возврат массива считанных экземпляров
        //}

        //public Worker GetWorkerById(int id)
        //{
        //    // происходит чтение из файла, возвращается Worker
        //    // с запрашиваемым ID
        //}

        public void DeleteWorker(int id)
        {
            // считывается файл, находится нужный Worker
            // происходит запись в файл всех Worker,
            // кроме удаляемого
        }

        public void AddWorker(Worker worker)                                             // присваиваем worker уникальный ID,                                                                                        
        {                                                                                // дописываем нового worker в файл"
            int maxID = 0;

            var lines = File.ReadAllLines("practical work.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (!string.IsNullOrWhiteSpace(line))
                {
                    var parts = line.Split('#');

                    if (int.TryParse(parts[0], out int currentID))
                    {
                        if (currentID > maxID)
                        {
                            maxID = currentID;
                        }
                    }
                }
            }
            worker.ID = maxID + 1;

            string workerData = string.Join("#",
                worker.ID,
                worker.TimeNow,
                worker.FIO,
                worker.Age,
                worker.Height,
                worker.DateBirth,
                worker.PlaceBirth);

            File.AppendAllText("practical work.txt", workerData + Environment.NewLine);

            Console.WriteLine("Новый работник добавлен!");
        }

        //public Worker[] GetWorkersBetweenTwoDates(DateTime dateFrom, DateTime dateTo)
        //{
        //    // здесь происходит чтение из файла
        //    // фильтрация нужных записей
        //    // и возврат массива считанных экземпляров
        //}
    }
}    




