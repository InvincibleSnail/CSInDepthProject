using System.Collections;
using System.Text.Json;

namespace CSInDepthProject.ChapterOne;

public class Product
{
    readonly private string name;

    public string Name { get; private set; }

    readonly private decimal? price;

    public decimal? Price { get; private set; }

    public Product()
    {
    }

    public Product(string name, decimal? price = null)
    {
        Name = name;
        Price = price;
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>()
        {
            new Product { Name = "West Side Story" },
            new Product { Name = "Assassins" },
            new Product { Name = "Frogs", Price = 13.99m },
            new Product { Name = "Sweeney Todd", Price = 10.99m },
        };
    }

    public override string ToString()
    {
        return string.Format("{0}:{1}", Name, Price);
    }
}