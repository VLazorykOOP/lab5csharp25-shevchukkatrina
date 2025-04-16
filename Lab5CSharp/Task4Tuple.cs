using System;
using System.Collections.Generic;

public class TupleProcessor
{
    public static void RunTupleExample()
    {
        // Кортеж: (Прізвище, Ім'я, По батькові, Адреса, Номер телефону, Вік)
        List<(string LastName, string FirstName, string MiddleName, string Address, string PhoneNumber, int Age)> people =
            new List<(string, string, string, string, string, int)>
            {
                    ("Іваненко", "Іван", "Іванович", "вул. Шевченка 1", "0671234567", 25),
                    ("Петренко", "Петро", "Петрович", "вул. Франка 2", "0672345678", 30),
                    ("Сидоренко", "Сидір", "Сидорович", "вул. Лесі Українки 3", "0673456789", 25),
                    ("Коваленко", "Ольга", "Олегівна", "вул. Гончара 4", "0674567890", 35)
            };

        Console.WriteLine("Початковий масив людей:");
        PrintPeople(people);

        int ageToRemove = 25;
        RemovePeopleByAge(people, ageToRemove);

        Console.WriteLine($"\nМасив після видалення людей з віком {ageToRemove}:");
        PrintPeople(people);

        int indexToAddAfter = 0; // Додаємо після першого елемента (індекс 0)
        var newPerson = (
            LastName: "Новаченко",
            FirstName: "Марія",
            MiddleName: "Василівна",
            Address: "вул. Котляревського 5",
            PhoneNumber: "0675678901",
            Age: 28
        );

        AddPersonAfterIndex(people, indexToAddAfter, newPerson);

        Console.WriteLine($"\nМасив після додавання нової людини після індексу {indexToAddAfter}:");
        PrintPeople(people);

        Console.ReadKey();
    }

    static void PrintPeople(List<(string LastName, string FirstName, string MiddleName, string Address, string PhoneNumber, int Age)> people)
    {
        for (int i = 0; i < people.Count; i++)
        {
            var person = people[i];
            Console.WriteLine($"{i}. {person.LastName} {person.FirstName} {person.MiddleName}, " +
                             $"Адреса: {person.Address}, Телефон: {person.PhoneNumber}, Вік: {person.Age}");
        }
    }

    static void RemovePeopleByAge(List<(string LastName, string FirstName, string MiddleName, string Address, string PhoneNumber, int Age)> people, int age)
    {
        people.RemoveAll(p => p.Age == age);
    }

    static void AddPersonAfterIndex(List<(string LastName, string FirstName, string MiddleName, string Address, string PhoneNumber, int Age)> people,
                                  int index,
                                  (string LastName, string FirstName, string MiddleName, string Address, string PhoneNumber, int Age) person)
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

