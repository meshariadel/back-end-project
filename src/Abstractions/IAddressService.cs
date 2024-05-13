namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IAddressService
    {

        public Address FindAll(Guid userId);

        public Address? FindOne(Guid address);




        public Address CreateOne(Address address);




        public Address UpdateOne(Guid foundAddress, Address updatedAddress);



    }
}