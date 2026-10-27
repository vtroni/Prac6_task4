using System;
using System.Text.Json;
using System.Text.Json.Serialization;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Price { get; set; }

    [JsonIgnore]
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        Product product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 1600,
            Quantity = 7
        };

        string json = JsonSerializer.Serialize(
            product,
            new JsonSerializerOptions { WriteIndented = true }
        );

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}