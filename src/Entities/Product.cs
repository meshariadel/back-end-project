using System.Drawing;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers;

public class Product
{

    private string _ProductId { get; } = Guid.NewGuid().ToString();
    private string _CategoryId { get; } = Guid.NewGuid().ToString();
    private ProductSize _Size { get; set; }
    private string? _Color { get; set; }
    private double _Price { get; set; }
    private int _Stock { get; set; }
    private string? _Img { get; set; }
    private string? _Name { get; set; }
    private string? _description { get; set; }
    public Product(ProductSize size, string color, double price,
    int stock, string name, string description, string img)
    {
        _Size = size;
        _Color = color;
        _Price = price;
        _Stock = stock;
        _Img = img;
        _Name = name;
        _description = description;
    }
}
