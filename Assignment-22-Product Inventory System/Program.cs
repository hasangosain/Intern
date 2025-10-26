using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}

class ProductInventory
{
    private List<Product> products = new List<Product>();
    private string jsonFile = "products.json";
    private string csvFile = "products.csv";

    
    //  JSON Persistence Section
    

    // Load products from JSON file
    public void LoadFromJson()
    {
        if (File.Exists(jsonFile))
        {
            string json = File.ReadAllText(jsonFile);
            products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            Console.WriteLine(" Products loaded from JSON file.");
        }
        else
        {
            Console.WriteLine(" No JSON file found. Starting with an empty inventory.");
        }
    }

    // Save products to JSON file
    public void SaveToJson()
    {
        string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonFile, json);
        Console.WriteLine(" Products saved to JSON file successfully!");
    }

    // ----------------------------
    //  CSV ↔ JSON Conversion
    // ----------------------------

    // Convert current data to CSV
    public void ConvertToCsv()
    {
        using (StreamWriter writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("Name,Price,Quantity");
            foreach (var p in products)
            {
                writer.WriteLine($"{p.Name},{p.Price},{p.Quantity}");
            }
        }
        Console.WriteLine($" Data converted and saved to {csvFile}");
    }

    // Convert CSV data to JSON
    public void ConvertCsvToJson()
    {
        if (!File.Exists(csvFile))
        {
            Console.WriteLine(" CSV file not found. Please convert to CSV first or create it manually.");
            return;
        }

        var csvLines = File.ReadAllLines(csvFile);
        var csvProducts = new List<Product>();

        for (int i = 1; i < csvLines.Length; i++) // skip header
        {
            var parts = csvLines[i].Split(',');
            if (parts.Length == 3)
            {
                string name = parts[0];
                double price = double.Parse(parts[1]);
                int quantity = int.Parse(parts[2]);
                csvProducts.Add(new Product(name, price, quantity));
            }
        }

        string json = JsonSerializer.Serialize(csvProducts, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(jsonFile, json);
        Console.WriteLine(" CSV data converted and saved as JSON!");
    }

    // ----------------------------
    //  Inventory Management
    // ----------------------------

    public void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        products.Add(new Product(name, price, quantity));
        Console.WriteLine("✅ Product added successfully!");
    }

    public void DisplayProducts()
    {
        if (products.Count == 0)
        {
            Console.WriteLine("No products available.");
            return;
        }

        Console.WriteLine("\n Product Inventory ");
        foreach (var p in products)
        {
            Console.WriteLine($"Name: {p.Name}, Price: Rs. {p.Price}, Quantity: {p.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        ProductInventory inventory = new ProductInventory();
        inventory.LoadFromJson(); // Load data at startup

        int choice;
        do
        {
            Console.WriteLine("\n PRODUCT INVENTORY SYSTEM ");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Display Products");
            Console.WriteLine("3. Save to JSON");
            Console.WriteLine("4. Convert JSON to CSV");
            Console.WriteLine("5. Convert CSV to JSON");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice)) choice = 0;

            switch (choice)
            {
                case 1:
                    inventory.AddProduct();
                    break;
                case 2:
                    inventory.DisplayProducts();
                    break;
                case 3:
                    inventory.SaveToJson();
                    break;
                case 4:
                    inventory.ConvertToCsv();
                    break;
                case 5:
                    inventory.ConvertCsvToJson();
                    break;
                case 6:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

        } while (choice != 6);
    }
}
