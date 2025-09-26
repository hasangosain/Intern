using System;

/// <summary>
/// Represents a car with basic properties and behaviors.
/// </summary>
class Car
{
    /// <summary>
    /// Gets or sets the manufacturer of the car (e.g., Toyota, Ford).
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// Gets or sets the model of the car (e.g., Corolla, Mustang).
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Gets or sets the year of manufacture of the car.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the color of the car.
    /// </summary>
    public string Color { get; set; }

    /// <summary>
    /// Starts the car and displays a message.
    /// </summary>
    public void Start()
    {
        Console.WriteLine($"{Year} {Make} {Model} is starting...");
    }

    /// <summary>
    /// Stops the car and displays the distance traveled and time taken.
    /// </summary>
    /// <param name="distance">The distance the car has traveled in meters.</param>
    /// <param name="time">The time taken in seconds.</param>
    public void Stop(int distance, int time)
    {
        Console.WriteLine($"{Year} {Make} {Model} has stopped at {distance} meters in {time} seconds.");
    }

    /// <summary>
    /// Accelerates the car and displays a message.
    /// </summary>
    public void Accelerate()
    {
        Console.WriteLine($"{Year} {Make} {Model} is accelerating ");
    }

    /// <summary>
    /// Displays information about the car (make, model, year, and color).
    /// </summary>
    public void GetInfo()
    {
        Console.WriteLine($"Car Info: {Year} {Color} {Make} {Model}");
    }
}

/// <summary>
/// The main program class used to test the <see cref="Car"/> class functionality.
/// </summary>
class Program
{
    /// <summary>
    /// The entry point of the program. Creates car objects and demonstrates their functionality.
    /// </summary>
    static void Main()
    {
        // Heading
        Console.WriteLine(" Details Of Car: \n");

        // Create car objects
        Car car1 = new Car { Make = "Hyundai", Model = "Creta", Year = 2021, Color = "White" };
        Car car2 = new Car { Make = "Suzuki", Model = "Swift", Year = 2020, Color = "Red" };
        Car car3 = new Car { Make = "Mahindra", Model = "Scorpio", Year = 2022, Color = "Blue" };

        // Test functionality
        car1.Start();
        car1.Accelerate();
        car1.GetInfo();
        car1.Stop(650, 600);  // Stopped at 650 meters in 600 seconds

        Console.WriteLine();

        car2.Start();
        car2.GetInfo();
        car2.Stop(1200, 1100); // Stopped at 1200 meters in 1100 seconds

        Console.WriteLine();

        car3.Start();
        car3.Accelerate();
        car3.GetInfo();
        car3.Stop(2000, 1800); // Stopped at 2000 meters in 1800 seconds
    }
}
