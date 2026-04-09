namespace StandardLogs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Запрашиваем путь у пользователя, решил так реализовать
            Console.WriteLine("Напишите путь файла");
            string path = Console.ReadLine();
            // Проверяем на существование файла по пути
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            StandardizationClass standardization = new StandardizationClass(path);
            standardization.ProcessAndSave();

            Console.WriteLine("Обработка завершена удачно.");
        }
    }

}

