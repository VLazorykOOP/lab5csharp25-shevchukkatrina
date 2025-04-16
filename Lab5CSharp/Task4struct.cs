using System;
using System.Collections.Generic;

public struct PersonStruct
{
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public string Address;
    public string Phone;
    public int Age;

    public PersonStruct(string lastName, string firstName, string middleName, string address, string phone, int age)
    {
        LastName = lastName;
        FirstName = firstName;
        MiddleName = middleName;
        Address = address;
        Phone = phone;
        Age = age;
    }
}

public class StructProcessor
{
    public static void RunStructExample()
    {
        var people = new List<PersonStruct>
        {
            new PersonStruct("Іваненко", "Іван", "Іванович", "Київ", "111", 25),
            new PersonStruct("Петренко", "Петро", "Петрович", "Львів", "222", 30),
            new PersonStruct("Сидоренко", "Сидір", "Сидорович", "Одеса", "333", 25)
        };

        int targetAge = 25;
        string afterPhone = "222";
        var newPerson = new PersonStruct("Новий", "Андрій", "Олегович", "Харків", "444", 28);

        people.RemoveAll(p => p.Age == targetAge);

        int insertIndex = people.FindIndex(p => p.Phone == afterPhone);
        if (insertIndex != -1)
            people.Insert(insertIndex + 1, newPerson);

        Console.WriteLine("Результат (Struct):");
        foreach (var p in people)
            Console.WriteLine($"{p.LastName} {p.FirstName} {p.MiddleName}, {p.Age} років, Тел: {p.Phone}, Адреса: {p.Address}");
    }
}
