using System;
using System.Collections.Generic;

public class TupleProcessor
{
    public static void RunTupleExample()
    {
        var people = new List<(string lastName, string firstName, string middleName, string address, string phone, int age)>
        {
            ("Іваненко", "Іван", "Іванович", "Київ", "111", 25),
            ("Петренко", "Петро", "Петрович", "Львів", "222", 30),
            ("Сидоренко", "Сидір", "Сидорович", "Одеса", "333", 25)
        };

        int targetAge = 25;
        string afterPhone = "222";
        var newPerson = ("Новий", "Андрій", "Олегович", "Харків", "444", 28);

        people.RemoveAll(p => p.age == targetAge);

        int insertIndex = people.FindIndex(p => p.phone == afterPhone);
        if (insertIndex != -1)
            people.Insert(insertIndex + 1, newPerson);

        Console.WriteLine("Результат (Tuple):");
        foreach (var p in people)
            Console.WriteLine($"{p.lastName} {p.firstName} {p.middleName}, {p.age} років, Тел: {p.phone}, Адреса: {p.address}");
    }
}
