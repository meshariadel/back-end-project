namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers{

public class Product
{

    public string ProductId { get; set; } = Guid.NewGuid().ToString();
    public string CategoryId { get; set; } = Guid.NewGuid().ToString();
    public ProductSize Size { get; set; }
    public string? Color { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public string? Img { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public Product(string productId, ProductSize size, string color, double price,
    int stock, string img, string name, string description)
    {
        ProductId = productId;
        Size = size;
        Color = color;
        Price = price;
        Stock = stock;
        Img = img;
        Name = name;
        Description = description;
    }
}
}