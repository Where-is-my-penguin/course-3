using System;


namespace Delete
{
    public struct Worker                                                    //Новое создание текста
    {
        /// <summary>
        /// Номер
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Текущее время
        /// </summary>
        public DateTime TimeNow { get; set; }
        /// <summary>
        /// Ф.И.О.
        /// </summary>
        public string FIO { get; set; }
        /// <summary>
        /// Полных лет
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// Рост(см)
        /// </summary>
        public ushort Height { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateBirth { get; set; }
        /// <summary>
        /// Место рождения
        /// </summary>
        public string PlaceBirth { get; set; }
        /// <summary>
        /// Данные сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="Age">Полных лет</param>
        /// <param name="Height">Рост</param>
        /// <param name="DateBirth">Дата рождения</param>
        /// <param name="PlaceBirth">Место рождения</param>
        public Worker(int ID, string FIO, byte Age, string PlaceBirth, DateTime DateBirth, ushort Height)
        {
            this.ID = ID;
            this.TimeNow = DateTime.Now;
            this.FIO = FIO;
            this.Age = Age;
            this.Height = Height;
            this.DateBirth = DateBirth;
            this.PlaceBirth = PlaceBirth;
        }
        /// <summary>
        /// Данные сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="Age">Полных лет</param>
        /// <param name="DateBirth">Дата рождения</param>
        /// <param name="PlaceBirth">Место рождения</param>
        public Worker(int ID, string FIO, byte Age, string PlaceBirth, DateTime DateBirth) :
            this(ID, FIO, Age, PlaceBirth, DateBirth, 0)
        {

        }
        /// <summary>
        /// Данные сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="Age">Полных лет</param>
        /// <param name="PlaceBirth">Место рождения</param>
        public Worker(int ID, string FIO, byte Age, string PlaceBirth) :
            this(ID, FIO, Age, PlaceBirth, new DateTime(2000, 2, 20), 0)
        {
            
        }
        /// <summary>
        /// Данные сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FIO">Ф.И.О.</param>
        /// <param name="Age">Полных лет</param>
        public Worker(int ID, string FIO, byte Age) :
            this(ID, FIO, Age, string.Empty, new DateTime(2000, 2, 20), 0)
        {
            
        }
        /// <summary>
        /// Данные сотрудника
        /// </summary>
        /// <param name="ID">ID</param>
        /// <param name="FIO">Ф.И.О.</param>
        public Worker(int ID, string FIO) :
            this(ID, FIO, 0, string.Empty, new DateTime(2000, 2, 20), 0)
        {
            
        }
    }
}

