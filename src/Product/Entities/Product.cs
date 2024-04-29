using System.Drawing;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;

public class Product
{

    public string _ProductId { get; set; }
    public string _CategoryId { get; } = Guid.NewGuid().ToString();
    public ProductSize _Size { get; set; }
    public string? _Color { get; set; }
    public double _Price { get; set; }
    public int _Stock { get; set; }
    public string? _Img { get; set; }
    public string? _Name { get; set; }
    public string? _description { get; set; }
    public Product(string productId, ProductSize size, string color, double price,
    int stock, string name, string description, string img)
    {
        _ProductId = productId;
        _Size = size;
        _Color = color;
        _Price = price;
        _Stock = stock;
        _Img = img;
        _Name = name;
        _description = description;
    }
}
