using System;
using System.IO;
using System.Text.Json;

class Config
{
    public string AppName { get; set; }
    public string Version { get; set; }
    public string Developer { get; set; }
}

class ConfigManager
{
    private string configFile = "config.json";

    // Save configuration to JSON file
    public void SaveConfig(Config config)
    {
        string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(configFile, json);
        Console.WriteLine(" Configuration saved successfully!");
    }

    // Load configuration from JSON file
    public Config LoadConfig()
    {
        if (!File.Exists(configFile))
        {
            Console.WriteLine(" Config file not found. Creating default configuration...");
            Config defaultConfig = new Config
            {
                AppName = "Student Records System",
                Version = "1.0",
                Developer = "Hasan Gosain"
            };
            SaveConfig(defaultConfig);
            return defaultConfig;
        }

        string json = File.ReadAllText(configFile);
        return JsonSerializer.Deserialize<Config>(json);
    }
}

class Program
{
    static void Main()
    {
        ConfigManager manager = new ConfigManager();

        // Load existing config or create new
        Config config = manager.LoadConfig();

        Console.WriteLine("\n APPLICATION CONFIGURATION ");
        Console.WriteLine($"App Name: {config.AppName}");
        Console.WriteLine($"Version: {config.Version}");
        Console.WriteLine($"Developer: {config.Developer}");
    }
}