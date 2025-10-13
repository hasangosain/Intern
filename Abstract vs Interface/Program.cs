//Abstract                                            Interface
//Contains both declaration & definition of methods.  Contains only declaration of methods.
//                                                    From C# 8.0, defination is also possible.
//Keyword: abstract                                   Keyword: interface
//supports mutiple inheritance.                       does not support multiple inheritance.
//can have fields, constructors, and destructors.     cannot have fields, constructors, and destructors.

using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

abstract class Animal
{
    // Field (common data for all animals)
    public string AnimalName;

    // Constructor (to initialize AnimalName)
    public Animal(string animalName)
    {
        AnimalName = animalName;
    }

    // Abstract method - must be implemented by derived classes
    public abstract void MakeSound();

    // Concrete method - common to all animals
    public void Eat()
    {
        Console.WriteLine($"{AnimalName} is eating.");
    }
}

// Derived class 1
class Dog : Animal
{
    public Dog(string animalName) : base(animalName) { }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine($"{AnimalName} says: Woof! Woof!");
    }
}

// Derived class 2
class Cat : Animal
{
    public Cat(string animalName) : base(animalName) { }

    // Implement abstract method
    public override void MakeSound()
    {
        Console.WriteLine($"{AnimalName} says: Meow!");
    }
}

class Program
{
    static void Main()
    {
        Animal dog = new Dog("Buddy");
        Animal cat = new Cat("Kitty");

        dog.MakeSound();  // Calls Dog's version
        dog.Eat();        // Uses base class method

        cat.MakeSound();  // Calls Cat's version
        cat.Eat();        // Uses base class method
    }
}




//Interface
//It only contains method declarations (no implementation).
//Any class that implements the interface must provide definitions for all its methods.
//creating objects of Dog and Bird.But their reference type is the interface ISoundMaker
//This shows polymorphism — one interface type can refer to many different objects.

//using System;
//interface ISoundMaker
//{
//    void MakeSound();  // Method signature only, no body
//}

//// Implementation 1: Dog
//class Dog : ISoundMaker
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Dog says: Woof");
//    }
//}

//// Implementation 2: Bird
//class Bird : ISoundMaker
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Bird says: Chirp");
//    }
//}

//// Main Program
//class Program
//{
//    static void Main()
//    {
//        ISoundMaker dog = new Dog();
//        ISoundMaker bird = new Bird();

//        dog.MakeSound();  // Calls Dog's implementation
//        bird.MakeSound(); // Calls Bird's implementation
//    }
//}
