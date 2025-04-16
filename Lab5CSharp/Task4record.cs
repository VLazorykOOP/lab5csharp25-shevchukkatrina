using System;
using System.Collections.Generic;

    // Record - це неявно незмінний тип даних
    public record Persona(
        string LastName,
        string FirstName,
        string MiddleName,
        string Address,
        string PhoneNumber,
        int Age
    )
    {
        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}, Адреса: {Address}, Телефон: {PhoneNumber}, Вік: {Age}";
        }
    }

    public class RecordProcessor
{
    public static void RunRecordExample()
    {
        // Створення масиву людей за допомогою записів
        List<Persona> people = new List<Persona>
            {
                new Persona("Іваненко", "Іван", "Іванович", "вул. Шевченка 1", "0671234567", 25),
                new Persona("Петренко", "Петро", "Петрович", "вул. Франка 2", "0672345678", 30),
                new Persona("Сидоренко", "Сидір", "Сидорович", "вул. Лесі Українки 3", "0673456789", 25),
                new Persona("Коваленко", "Ольга", "Олегівна", "вул. Гончара 4", "0674567890", 35)
            };

        Console.WriteLine("Початковий масив людей:");
        PrintPeople(people);

        int ageToRemove = 25;
        RemovePeopleByAge(people, ageToRemove);

        Console.WriteLine($"\nМасив після видалення людей з віком {ageToRemove}:");
        PrintPeople(people);

        int indexToAddAfter = 0; 
        Persona newPersona = new Persona(
            "Новаченко",
            "Марія",
            "Василівна",
            "вул. Котляревського 5",
            "0675678901",
            28
        );

        AddPersonAfterIndex(people, indexToAddAfter, newPersona);

        Console.WriteLine($"\nМасив після додавання нової людини після індексу {indexToAddAfter}:");
        PrintPeople(people);

        Console.ReadKey();
    }

    static void PrintPeople(List<Persona> people)
    {
        for (int i = 0; i < people.Count; i++)
        {
            Console.WriteLine($"{i}. {people[i]}");
        }
    }

    static void RemovePeopleByAge(List<Persona> people, int age)
    {
        people.RemoveAll(p => p.Age == age);
    }

    static void AddPersonAfterIndex(List<Persona> people, int index, Persona person)
    {
        if (index >= 0 && index < people.Count)
        {
            people.Insert(index + 1, person);
        }
        else
        {
            Console.WriteLine("Некоректний індекс для вставки!");
        }
    }
}

