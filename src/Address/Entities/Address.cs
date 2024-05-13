namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class Address
    {


        public Guid AddressId { get; set; }
        public Guid UserId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int HouseNum { get; set; }
        public int Zipcode { get; set; }

        public EnumType AddressType { get; set; }
        public User User { get; set; }

        public enum EnumType
        {
            Billing,
            Shipping
        }

    }
}