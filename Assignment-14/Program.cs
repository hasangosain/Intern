using System;

/// <summary>
/// Base class representing a generic Animal.
/// </summary>
class Animal
{
    /// <summary>
    /// Gets or sets the name of the animal.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the age of the animal.
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Initializes a new instance of the Animal class.
    /// </summary>
    /// <param name="name">Name of the animal</param>
    /// <param name="age">Age of the animal</param>
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    /// <summary>
    /// Virtual method to be overridden by derived classes to make sound.
    /// </summary>
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

/// <summary>
/// Represents a dog, derived from Animal.
/// </summary>
class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Dog) barks.");
    }
}

/// <summary>
/// Represents a cat, derived from Animal.
/// </summary>
class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Cat) meows.");
    }
}

/// <summary>
/// Represents a bird, derived from Animal.
/// </summary>
class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} (Bird) chirps.");
    }
}

/// <summary>
/// Base class representing a generic Shape.
/// </summary>
abstract class Shape
{
    /// <summary>
    /// Abstract method to calculate area (must be implemented by derived classes).
    /// </summary>
    public abstract double CalculateArea();
}

/// <summary>
/// Represents a Rectangle shape.
/// </summary>
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea()
    {
        return Width * Height;
    }
}

/// <summary>
/// Represents a Circle shape.
/// </summary>
class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Animal Sounds");
        Dog dog = new Dog("Buddy", 3);
        Cat cat = new Cat("Whiskers", 2);
        Bird bird = new Bird("Tweety", 1);

        dog.MakeSound();
        cat.MakeSound();
        bird.MakeSound();

        Console.WriteLine("\n Shape Areas ");
        Rectangle rectangle = new Rectangle(3, 6);
        Circle circle = new Circle(4);

        Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
        Console.WriteLine($"Circle Area: {circle.CalculateArea():F2}");
    }
}
