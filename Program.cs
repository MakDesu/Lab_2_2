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
            List<ComputerFirmClient> clients = new List<ComputerFirmClient>();
            string command;

            Console.WriteLine("=== Керування клієнтами комп'ютерної фірми ===");
            Console.WriteLine("Доступні команди:");
            Console.WriteLine("add - Додати клієнта");
            Console.WriteLine("remove - Видалити клієнта за ID");
            Console.WriteLine("list - Відобразити список клієнтів");
            Console.WriteLine("exit - Вийти з програми");

            do
            {
                Console.Write("\nВведіть команду: ");
                command = Console.ReadLine()?.ToLower();

                switch (command)
                {
                    case "add":
                        AddClient(clients);
                        break;

                    case "remove":
                        RemoveClient(clients);
                        break;

                    case "list":
                        ListClients(clients);
                        break;

                    case "exit":
                        Console.WriteLine("Завершення роботи...");
                        break;

                    default:
                        Console.WriteLine("Невідома команда. Спробуйте ще раз.");
                        break;
                }
            } while (command != "exit");
        }

        static void AddClient(List<ComputerFirmClient> clients)
        {
            Console.WriteLine("\n=== Додавання нового клієнта ===");
            Console.Write("Введіть ID клієнта: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.Write("Введіть ім'я клієнта: ");
            string name = Console.ReadLine();

            Console.Write("Введіть email клієнта: ");
            string email = Console.ReadLine();

            Console.Write("Введіть телефон клієнта: ");
            string phone = Console.ReadLine();

            Console.Write("Введіть адресу клієнта: ");
            string address = Console.ReadLine();

            clients.Add(new ComputerFirmClient(id, name, email, phone, address));
            Console.WriteLine("Клієнт успішно доданий!");
        }

        static void RemoveClient(List<ComputerFirmClient> clients)
        {
            Console.WriteLine("\n=== Видалення клієнта ===");
            Console.Write("Введіть ID клієнта для видалення: ");
            int id = int.Parse(Console.ReadLine() ?? "0");

            var client = clients.Find(c => c.ClientId == id);
            if (client != null)
            {
                clients.Remove(client);
                Console.WriteLine("Клієнт успішно видалений!");
            }
            else
            {
                Console.WriteLine("Клієнта з таким ID не знайдено.");
            }
        }

        static void ListClients(List<ComputerFirmClient> clients)
        {
            Console.WriteLine("\n=== Список клієнтів ===");
            if (clients.Count == 0)
            {
                Console.WriteLine("Список клієнтів порожній.");
                return;
            }

            foreach (var client in clients)
            {
                client.DisplayInfo();
                Console.WriteLine("---");
            }
        }
    }

         
     
     

            
}