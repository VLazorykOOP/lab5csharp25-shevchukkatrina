using System;
using System.Collections.Generic;
using static Person;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть номер завдання:");
        Console.WriteLine("1 - Task1+Task2(Деталь + вивід)");
        Console.WriteLine("2 - Task3 (Клієнти)");
        Console.WriteLine("3.1 - Task4 Struct");
        Console.WriteLine("3.2 - Task4 Tuple");
        Console.WriteLine("3.3 - Task4 Record");
        Console.Write("Ваш вибір: ");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                Task1();
                break;

            case "2":
                Task3();
                break;

            case "3.1":
                StructProcessor.RunStructExample();
                break;

            case "3.2":
                TupleProcessor.RunTupleExample();
                break;

            case "3.3":
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

    static void Task3()
    {
        ClientDatabase database = new ClientDatabase();

        database.AddClient(new Depositor("Іванов", new DateTime(2023, 5, 15), 50000, 12.5));
        database.AddClient(new Creditor("Петров", new DateTime(2023, 5, 15), 100000, 14.2, 75000));
        database.AddClient(new Organization("ТОВ Глобус", new DateTime(2023, 6, 10), "26007123456789", 230000));
        database.AddClient(new Depositor("Сидоров", new DateTime(2023, 6, 10), 75000, 11.8));
        database.AddClient(new Organization("ПП Зоря", new DateTime(2023, 7, 22), "26001987654321", 180000));

        database.DisplayAllClients();

        DateTime searchDate = new DateTime(2023, 5, 15);
        database.FindClientsByDate(searchDate);

        searchDate = new DateTime(2023, 6, 10);
        database.FindClientsByDate(searchDate);

        searchDate = new DateTime(2023, 1, 1);
        database.FindClientsByDate(searchDate);

        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
