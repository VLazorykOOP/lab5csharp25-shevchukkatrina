using System;

public class Detail
{
    // Поля базового класу
    public string Name { get; set; }
    public int ID { get; set; }

    // Конструктори
    public Detail()
    {
        Console.WriteLine("Detail: Конструктор за замовчуванням");
    }

    public Detail(string name, int id)
    {
        Name = name;
        ID = id;
        Console.WriteLine("Detail: Конструктор з параметрами");
    }

    public Detail(Detail detail)
    {
        Name = detail.Name;
        ID = detail.ID;
        Console.WriteLine("Detail: Конструктор копіювання");
    }

    // Метод для виведення інформації
    public virtual void Show()
    {
        Console.WriteLine($"Detail: Назва - {Name}, ID - {ID}");
    }

    // Деструктор
    ~Detail()
    {
        Console.WriteLine("Detail: Деструктор");
    }
}

public class Mechanism : Detail
{
    // Поля для похідного класу Mechanism
    public int ComponentCount { get; set; }

    // Конструктори
    public Mechanism() : base()
    {
        Console.WriteLine("Mechanism: Конструктор за замовчуванням");
    }

    public Mechanism(string name, int id, int componentCount) : base(name, id)
    {
        ComponentCount = componentCount;
        Console.WriteLine("Mechanism: Конструктор з параметрами");
    }

    public Mechanism(Mechanism mechanism) : base(mechanism)
    {
        ComponentCount = mechanism.ComponentCount;
        Console.WriteLine("Mechanism: Конструктор копіювання");
    }

    // Метод для виведення інформації
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Mechanism: Кількість компонентів - {ComponentCount}");
    }

    // Деструктор
    ~Mechanism()
    {
        Console.WriteLine("Mechanism: Деструктор");
    }
}

public class Product : Mechanism
{
    // Поля для похідного класу Product
    public string ProductType { get; set; }

    // Конструктори
    public Product() : base()
    {
        Console.WriteLine("Product: Конструктор за замовчуванням");
    }

    public Product(string name, int id, int componentCount, string productType) : base(name, id, componentCount)
    {
        ProductType = productType;
        Console.WriteLine("Product: Конструктор з параметрами");
    }

    public Product(Product product) : base(product)
    {
        ProductType = product.ProductType;
        Console.WriteLine("Product: Конструктор копіювання");
    }

    // Метод для виведення інформації
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Product: Тип продукту - {ProductType}");
    }

    // Деструктор
    ~Product()
    {
        Console.WriteLine("Product: Деструктор");
    }
}

public class Node : Product
{
    // Поля для похідного класу Node
    public int NodeID { get; set; }

    // Конструктори
    public Node() : base()
    {
        Console.WriteLine("Node: Конструктор за замовчуванням");
    }

    public Node(string name, int id, int componentCount, string productType, int nodeID) : base(name, id, componentCount, productType)
    {
        NodeID = nodeID;
        Console.WriteLine("Node: Конструктор з параметрами");
    }

    public Node(Node node) : base(node)
    {
        NodeID = node.NodeID;
        Console.WriteLine("Node: Конструктор копіювання");
    }

    // Метод для виведення інформації
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Node: ID вузла - {NodeID}");
    }

    // Деструктор
    ~Node()
    {
        Console.WriteLine("Node: Деструктор");
    }
}
