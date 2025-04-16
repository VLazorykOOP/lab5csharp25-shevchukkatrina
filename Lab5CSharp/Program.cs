using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть номер завдання:");
        Console.WriteLine("1 - Task1 (Деталь)");
        Console.WriteLine("2 - Task2 (Деталь + вивід)");
        Console.WriteLine("3 - Task3 (Клієнти)");
        Console.WriteLine("41 - Task4 Struct");
        Console.WriteLine("42 - Task4 Tuple");
        Console.WriteLine("43 - Task4 Record");
        Console.Write("Ваш вибір: ");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Task1();
                break;

            case "2":
                Task2();
                break;

            case "3":
                Task3();
                break;

            case "41":
                StructProcessor.RunStructExample();
                break;

            case "42":
                TupleProcessor.RunTupleExample();
                break;

            case "43":
                RecordProcessor.RunRecordExample();
                break;

            default:
                Console.WriteLine("Невідомий вибір.");
                break;
        }
    }

    static void Task1()
    {
        Console.WriteLine("Створення об'єкта типу Detail:");
        Detail detail = new Detail("Деталь 1", 101);
        detail.Show();
        Console.WriteLine();

        Console.WriteLine("Створення об'єкта типу Mechanism:");
        Mechanism mechanism = new Mechanism("Механізм 1", 201, 5);
        mechanism.Show();
        Console.WriteLine();

        Console.WriteLine("Створення об'єкта типу Product:");
        Product product = new Product("Продукт 1", 301, 10, "Тип 1");
        product.Show();
        Console.WriteLine();

        Console.WriteLine("Створення об'єкта типу Node:");
        Node node = new Node("Вузол 1", 401, 15, "Тип 2", 1001);
        node.Show();
        Console.WriteLine();

        Console.WriteLine("Кінець програми");
    }

    static void Task2()
    {
    }


    static void Task3()
    {
        List<Client> clients = new List<Client>
        {
            new Depositor("Петренко", new DateTime(2023, 5, 1), 10000, 5.5),
            new Creditor("Іваненко", new DateTime(2023, 5, 2), 20000, 12.5, 8000),
            new Organization("ТОВ Альфа", new DateTime(2023, 5, 1), "UA12345678", 150000),
            new Depositor("Сидоренко", new DateTime(2024, 2, 10), 5000, 4.8)
        };

        Console.WriteLine("=== Усі клієнти ===\n");

        foreach (var client in clients)
        {
            client.ShowInfo();
        }

        Console.WriteLine("\nВведіть дату для пошуку (у форматі рррр-мм-дд):");
        string input = Console.ReadLine();

        if (DateTime.TryParse(input, out DateTime searchDate))
        {
            Console.WriteLine($"\nКлієнти, що співпрацюють з банком з {searchDate.ToShortDateString()}:\n");

            foreach (var client in clients)
            {
                if (client.IsMatchDate(searchDate))
                    client.ShowInfo();
            }
        }
        else
        {
            Console.WriteLine("Некоректний формат дати.");
        }
    }
}
