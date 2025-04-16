using System;
using System.Collections.Generic;

public record PersonRecord(
    string LastName,
    string FirstName,
    string MiddleName,
    string Address,
    string Phone,
    int Age
);

public class RecordProcessor
{
    public static void RunRecordExample()
    {
        List<PersonRecord> people = new List<PersonRecord>
        {
            new("Іваненко", "Іван", "Іванович", "Київ", "111", 25),
            new("Петренко", "Петро", "Петрович", "Львів", "222", 30),
            new("Сидоренко", "Сидір", "Сидорович", "Одеса", "333", 25)
        };

        int targetAge = 25;
        string afterPhone = "222";
        var newPerson = new PersonRecord("Новий", "Андрій", "Олегович", "Харків", "444", 28);

        people.RemoveAll(p => p.Age == targetAge);

        int insertIndex = people.FindIndex(p => p.Phone == afterPhone);
        if (insertIndex != -1)
            people.Insert(insertIndex + 1, newPerson);

        Console.WriteLine("Результат (Record):");
        foreach (var p in people)
            Console.WriteLine($"{p.LastName} {p.FirstName} {p.MiddleName}, {p.Age} років, Тел: {p.Phone}, Адреса: {p.Address}");
    }
}
