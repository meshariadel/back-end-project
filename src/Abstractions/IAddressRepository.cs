namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IAddressRepository
    {


        public Address? FindOne(Guid foundAddress);


        public IEnumerable<Address> FindAll(Guid userId);



        public Address CreateOne(Address address);

        public Address UpdateOne(Address updatedAddress);

    }
}