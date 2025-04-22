using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тестування класу ComputerFirmClient ===");

            // Створення об'єкта клієнта за допомогою конструктора з параметрами
            ComputerFirmClient client = new ComputerFirmClient(1, "Іван Іванов", "ivan.ivanov@gmail.com", "+380123456789", "м. Київ, вул. Шевченка, 12");

            // Відображення інформації про клієнта
            Console.WriteLine("\nІнформація про клієнта:");
            client.DisplayInfo();

            // Зміна деяких властивостей об'єкта
            Console.WriteLine("\nОновлюємо інформацію про клієнта...");
            client.Name = "Петро Петров";
            client.Email = "petro.petrov@gmail.com";

            // Відображення оновленої інформації
            Console.WriteLine("\nОновлена інформація про клієнта:");
            client.DisplayInfo();

            // Завершення програми
            Console.WriteLine("\nТестування завершено.");


        }

    }
        
}