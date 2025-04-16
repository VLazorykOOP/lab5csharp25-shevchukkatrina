using System;

public abstract class Client
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }

    public Client(string name, DateTime startDate)
    {
        Name = name;
        StartDate = startDate;
    }

    public abstract void ShowInfo();

    public bool IsMatchDate(DateTime date)
    {
        return StartDate.Date >= date.Date;
    }
}

public class Depositor : Client
{
    public double Amount { get; set; }
    public double InterestRate { get; set; }

    public Depositor(string name, DateTime startDate, double amount, double interestRate)
        : base(name, startDate)
    {
        Amount = amount;
        InterestRate = interestRate;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Депонент: {Name}, Вклад: {Amount}, Процент: {InterestRate}%");
    }
}

public class Creditor : Client
{
    public double LoanAmount { get; set; }
    public double InterestRate { get; set; }
    public double Payment { get; set; }

    public Creditor(string name, DateTime startDate, double loanAmount, double interestRate, double payment)
        : base(name, startDate)
    {
        LoanAmount = loanAmount;
        InterestRate = interestRate;
        Payment = payment;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Кредитор: {Name}, Позика: {LoanAmount}, Процент: {InterestRate}%, Платіж: {Payment}");
    }
}

public class Organization : Client
{
    public string TaxId { get; set; }
    public double Capital { get; set; }

    public Organization(string name, DateTime startDate, string taxId, double capital)
        : base(name, startDate)
    {
        TaxId = taxId;
        Capital = capital;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Організація: {Name}, ІНН: {TaxId}, Капітал: {Capital}");
    }
}
