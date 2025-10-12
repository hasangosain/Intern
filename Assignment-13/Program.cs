using System;

/// <summary>
/// Represents an employee with name, age, and salary details.
/// Includes validation and a method to calculate yearly bonus.
/// </summary>
class Employee
{
    // Private fields
    private string employeeName;
    private int employeeAge;
    private double employeeSalary;

    /// <summary>
    /// Gets or sets the employee's name.
    /// Cannot be empty or whitespace.
    /// </summary>
    public string EmployeeName
    {
        get { return employeeName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                Console.WriteLine(" Employee name cannot be empty.");
                return;
            }
            employeeName = value;
        }
    }

    /// <summary>
    /// Gets or sets the employee's age.
    /// Must be between 18 and 65.
    /// </summary>
    public int EmployeeAge
    {
        get { return employeeAge; }
        set
        {
            if (value < 18 || value > 65)
            {
                Console.WriteLine(" Employee age must be between 18 and 65.");
                return;
            }
            employeeAge = value;
        }
    }

    /// <summary>
    /// Gets or sets the employee's salary.
    /// Must be positive.
    /// </summary>
    public double EmployeeSalary
    {
        get { return employeeSalary; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine(" Employee salary must be a positive.");
                return;
            }
            employeeSalary = value;
        }
    }

    /// <summary>
    /// Initializes a new instance of the Employee class with the given details.
    /// </summary>
    /// <param name="employeeName">Employee name</param>
    /// <param name="employeeAge">Employee age</param>
    /// <param name="employeeSalary">Employee salary</param>
    public Employee(string employeeName, int employeeAge, double employeeSalary)
    {
        EmployeeName = employeeName;
        EmployeeAge = employeeAge;
        EmployeeSalary = employeeSalary;
    }

    /// <summary>
    /// Calculates the yearly bonus (10% of salary).
    /// </summary>
    /// <returns>Yearly bonus amount</returns>
    public double CalculateYearlyBonus()
    {
        return EmployeeSalary * 0.10;
    }

    /// <summary>
    /// Displays employee details.
    /// </summary>
    public void DisplayInfo()
    {
        Console.WriteLine($"Employee Name: {EmployeeName}");
        Console.WriteLine($"Employee Age: {EmployeeAge}");
        Console.WriteLine($"Employee Salary: {EmployeeSalary:C}");
        Console.WriteLine($"Yearly Bonus: {CalculateYearlyBonus():C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an Employee object
        Employee emp = new Employee("Hasan Gosain", 24, 55000);

        // Display employee information
        emp.DisplayInfo();
    }
}
