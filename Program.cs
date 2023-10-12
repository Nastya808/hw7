using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

/*
public class Money
{
    public int Dollars { get; set; }
    public int Cents { get; set; }

    public Money(int dollars, int cents)
    {
        Dollars = dollars;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"{Dollars} доларів {Cents} центів");
    }

    public void SetAmount(int dollars, int cents)
    {
        Dollars = dollars;
        Cents = cents;
    }
}

public class Product
{
    public string Name { get; set; }
    public Money Price { get; set; }

    public Product(string name, Money price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine($"{Name}: {Price.Dollars} доларів {Price.Cents} центів");
    }

    public void ReducePrice(int amount)
    {
        Price.Dollars -= amount;
    }
}

class Program
{
    static void Main()
    {
        Money money1 = new Money(10, 50); 
        Money money2 = new Money(5, 25); 

        Product product = new Product("Телевізор", money1);
        product.Display();  
        product.ReducePrice(2);
        product.Display();  
    }
}
*/

public class Device
{
    public string Name { get; set; }
    public string Features { get; set; }

    public Device(string name, string features)
    {
        Name = name;
        Features = features;
    }

    public void Sound()
    {
        Console.WriteLine($"Звук пристрою {Name}");
    }

    public void Show()
    {
        Console.WriteLine($"Назва пристрою: {Name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Опис пристрою: {Features}");
    }
}

public class Kettle : Device
{
    public string Capacity { get; set; }

    public Kettle(string name, string features, string capacity) : base(name, features)
    {
        Capacity = capacity;
    }
}

public class Microwave : Device
{
    public string Power { get; set; }

    public Microwave(string name, string features, string power) : base(name, features)
    {
        Power = power;
    }
}

public class Car : Device
{
    public string Speed { get; set; }

    public Car(string name, string features, string speed) : base(name, features)
    {
        Speed = speed;
    }
}

public class Steamboat : Device
{
    public string SteamPressure { get; set; }

    public Steamboat(string name, string features, string steamPressure) : base(name, features)
    {
        SteamPressure = steamPressure;
    }
}

class Program
{
    static void Main()
    {
        Kettle kettle = new Kettle("Чайник", "Об'єм 1 літр", "1 літр");
        kettle.Sound();
        kettle.Show();
        kettle.Desc();

        Microwave microwave = new Microwave("Мікрохвильовка", "800 Ватт", "800 Ватт");
        microwave.Sound();
        microwave.Show();
        microwave.Desc();

        Car car = new Car("Автомобіль", "Чотири колеса", "150 км/год");
        car.Sound();
        car.Show();
        car.Desc();

        Steamboat steamboat = new Steamboat("Пароплав", "Паровий двигун", "5 бар");
        steamboat.Sound();
        steamboat.Show();
        steamboat.Desc();
    }
}