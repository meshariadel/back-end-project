namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserCreateDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserReadDto
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

    }

    public class UserUpdateDto
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class UserLogin
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}