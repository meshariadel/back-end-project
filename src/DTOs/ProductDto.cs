
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.DTOs
{
    public class ProductDto
    {

        public class ProductReadDto
        {
            public string ProductId { get; set; }

            public string CategoryId { get; set; }
            public string? Name { get; set; }

            public string? Description { get; set; }

            public int Stock { get; set; }

            public double Price { get; set; }

            public string? Color { get; set; }

        }

    }
}