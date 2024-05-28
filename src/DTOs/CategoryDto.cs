namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class CategoryReadDto
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }

    }
    public class CategoryUpdateDto
    {
        public string CategoryName { get; set; }
    }
    public class CategoryCreateDto
    {
        public string CategoryName { get; set; }
    }
}