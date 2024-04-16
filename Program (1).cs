
using System;

public class Program
{
    public static void Main()
    {
        // Task 1: Data Types, Variables, and Basic Operators
        int yourAge = 25; // Replace with your actual age
        string yourName = "Alice"; // Replace with your actual name
        double bankBalance = 1000.50;
        bankBalance *= 1.10; // Increase bank balance by 10%
        Console.WriteLine($"My name is {yourName}, I am {yourAge} years old, and my updated bank balance is: ${bankBalance:F2}");

        // Task 2: Control Structures and Classes
        Person person = new Person(yourName, yourAge);
        Console.WriteLine(person.IsAdult() ? $"{person.Name} is an adult." : $"{person.Name} is not an adult.");

        // Task 3: Inheritance and Class Hierarchy
        Rectangle rectangle = new Rectangle(10.0, 20.0);
        Circle circle = new Circle(5.0);
        Console.WriteLine($"Rectangle area: {rectangle.Area}");
        Console.WriteLine($"Circle area: {circle.Area}");
    }
}

// Task 2: Control Structures and Classes
public class Person
{
    private int age;
    public string Name { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        this.age = age;
    }

    public bool IsAdult()
    {
        return age >= 18;
    }
}

// Task 3: Inheritance and Class Hierarchy
public abstract class Shape
{
    protected double area;
    public double Area
    {
        get { return area; }
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
        area = length * width;
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
        area = Math.PI * radius * radius;
    }
}
