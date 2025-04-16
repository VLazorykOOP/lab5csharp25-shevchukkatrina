using System;
using System.Collections.Generic;

struct Person
{
    public string LastName;
    public string FirstName;
    public string MiddleName;
    public string Address;
    public string PhoneNumber;
    public int Age;

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName}, Адреса: {Address}, Телефон: {PhoneNumber}, Вік: {Age}";
    }

    public class StructProcessor
    {
        public static void RunStructExample()
        {
            List<Person> people = new List<Person>
            {
                new Person { LastName = "Іваненко", FirstName = "Іван", MiddleName = "Іванович", Address = "вул. Шевченка 1", PhoneNumber = "0671234567", Age = 25 },
                new Person { LastName = "Петренко", FirstName = "Петро", MiddleName = "Петрович", Address = "вул. Франка 2", PhoneNumber = "0672345678", Age = 30 },
                new Person { LastName = "Сидоренко", FirstName = "Сидір", MiddleName = "Сидорович", Address = "вул. Лесі Українки 3", PhoneNumber = "0673456789", Age = 25 },
                new Person { LastName = "Коваленко", FirstName = "Ольга", MiddleName = "Олегівна", Address = "вул. Гончара 4", PhoneNumber = "0674567890", Age = 35 }
            };

            Console.WriteLine("Початковий масив людей:");
            PrintPeople(people);

            int ageToRemove = 25;
            RemovePeopleByAge(people, ageToRemove);

            Console.WriteLine($"\nМасив після видалення людей з віком {ageToRemove}:");
            PrintPeople(people);

            int indexToAddAfter = 0; // Додаємо після першого елемента (індекс 0)
            Person newPerson = new Person
            {
                LastName = "Новаченко",
                FirstName = "Марія",
                MiddleName = "Василівна",
                Address = "вул. Котляревського 5",
                PhoneNumber = "0675678901",
                Age = 28
            };

            AddPersonAfterIndex(people, indexToAddAfter, newPerson);

            Console.WriteLine($"\nМасив після додавання нової людини після індексу {indexToAddAfter}:");
            PrintPeople(people);

            Console.ReadKey();
        }

        static void PrintPeople(List<Person> people)
        {
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine($"{i}. {people[i]}");
            }
        }

        static void RemovePeopleByAge(List<Person> people, int age)
        {
            people.RemoveAll(p => p.Age == age);
        }

        static void AddPersonAfterIndex(List<Person> people, int index, Person person)
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
}

