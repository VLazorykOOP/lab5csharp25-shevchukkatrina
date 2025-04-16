using System;
using System.Collections.Generic;

public abstract class Client
{
    public abstract void DisplayInfo();

    public abstract bool MatchesDate(DateTime date);
}

public class Depositor : Client
{
    public string LastName { get; set; }
    public DateTime DepositDate { get; set; }
    public decimal DepositAmount { get; set; }
    public double InterestRate { get; set; }

    public Depositor(string lastName, DateTime depositDate, decimal depositAmount, double interestRate)
    {
        LastName = lastName;
        DepositDate = depositDate;
        DepositAmount = depositAmount;
        InterestRate = interestRate;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("--- Вкладник ---");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Дата відкриття внеску: {DepositDate.ToShortDateString()}");
        Console.WriteLine($"Розмір внеску: {DepositAmount:C}");
        Console.WriteLine($"Відсоток по внеску: {InterestRate}%");
    }

    public override bool MatchesDate(DateTime date)
    {
        return DepositDate.Date == date.Date;
    }
}

public class Creditor : Client
{
    public string LastName { get; set; }
    public DateTime LoanDate { get; set; }
    public decimal LoanAmount { get; set; }
    public double InterestRate { get; set; }
    public decimal RemainingDebt { get; set; }

    public Creditor(string lastName, DateTime loanDate, decimal loanAmount, double interestRate, decimal remainingDebt)
    {
        LastName = lastName;
        LoanDate = loanDate;
        LoanAmount = loanAmount;
        InterestRate = interestRate;
        RemainingDebt = remainingDebt;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("--- Кредитор ---");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Дата видачі кредиту: {LoanDate.ToShortDateString()}");
        Console.WriteLine($"Розмір кредиту: {LoanAmount:C}");
        Console.WriteLine($"Відсоток по кредиту: {InterestRate}%");
        Console.WriteLine($"Остача боргу: {RemainingDebt:C}");
    }

    public override bool MatchesDate(DateTime date)
    {
        return LoanDate.Date == date.Date;
    }
}

public class Organization : Client
{
    public string Name { get; set; }
    public DateTime AccountOpenDate { get; set; }
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    public Organization(string name, DateTime accountOpenDate, string accountNumber, decimal balance)
    {
        Name = name;
        AccountOpenDate = accountOpenDate;
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("--- Організація ---");
        Console.WriteLine($"Назва: {Name}");
        Console.WriteLine($"Дата відкриття рахунку: {AccountOpenDate.ToShortDateString()}");
        Console.WriteLine($"Номер рахунку: {AccountNumber}");
        Console.WriteLine($"Сума на рахунку: {Balance:C}");
    }

    public override bool MatchesDate(DateTime date)
    {
        return AccountOpenDate.Date == date.Date;
    }
}

public class ClientDatabase
{
    private List<Client> clients;

    public ClientDatabase()
    {
        clients = new List<Client>();
    }

    public void AddClient(Client client)
    {
        clients.Add(client);
    }

    public void DisplayAllClients()
    {
        Console.WriteLine("\n=== ІНФОРМАЦІЯ ПРО ВСІХ КЛІЄНТІВ ===\n");

        if (clients.Count == 0)
        {
            Console.WriteLine("База клієнтів порожня.");
            return;
        }

        for (int i = 0; i < clients.Count; i++)
        {
            Console.WriteLine($"Клієнт #{i + 1}");
            clients[i].DisplayInfo();
            Console.WriteLine();
        }
    }

    public void FindClientsByDate(DateTime date)
    {
        Console.WriteLine($"\n=== КЛІЄНТИ, ЩО ПОЧАЛИ СПІВПРАЦЮ {date.ToShortDateString()} ===\n");

        bool found = false;

        for (int i = 0; i < clients.Count; i++)
        {
            if (clients[i].MatchesDate(date))
            {
                Console.WriteLine($"Клієнт #{i + 1}");
                clients[i].DisplayInfo();
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Клієнтів, що почали співпрацю {date.ToShortDateString()}, не знайдено.");
        }
    }
}
