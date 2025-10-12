using System;

/// <summary>
/// Abstract base class representing a generic vehicle.
/// </summary>
abstract class Vehicle
{
    /// <summary>
    /// Gets or sets the brand of the vehicle.
    /// </summary>
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the model of the vehicle.
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Initializes a new instance of the Vehicle class.
    /// </summary>
    /// <param name="brand">Brand of the vehicle.</param>
    /// <param name="model">Model of the vehicle.</param>
    public Vehicle(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    /// <summary>
    /// Abstract method to start the vehicle.
    /// Must be implemented by derived classes.
    /// </summary>
    public abstract void Start();
}

/// <summary>
/// Represents a car, derived from Vehicle.
/// </summary>
class Car : Vehicle
{
    public Car(string brand, string model) : base(brand, model) { }

    /// <summary>
    /// Starts the car with a smooth ignition.
    /// </summary>
    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} (Car) is starting smoothly.");
    }
}

/// <summary>
/// Represents a motorcycle, derived from Vehicle.
/// </summary>
class Motorcycle : Vehicle
{
    public Motorcycle(string brand, string model) : base(brand, model) { }

    /// <summary>
    /// Starts the motorcycle with a revving sound.
    /// </summary>
    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} (Motorcycle) is revving loudly.");
    }
}

/// <summary>
/// Represents a truck, derived from Vehicle.
/// </summary>
class Truck : Vehicle
{
    public Truck(string brand, string model) : base(brand, model) { }

    /// <summary>
    /// Starts the truck with a rumbling diesel sound.
    /// </summary>
    public override void Start()
    {
        Console.WriteLine($"{Brand} {Model} (Truck) rumbles as it starts.");
    }
}

/// <summary>
/// Demonstrates polymorphism with Vehicle array.
/// </summary>
class Program
{
    static void Main()
    {
        // Create an array of brand vehicles
        Vehicle[] vehicles = new Vehicle[]
        {
            new Car("Sakchyam Motors", "Swift"),
            new Motorcycle("Sajha Bike", "Rider 150"),
            new Truck("Himalaya Truck", "HT-5000")
        };

        // Demonstrate polymorphism
        foreach (var vehicle in vehicles)
        {
            vehicle.Start();
        }
    }
}
