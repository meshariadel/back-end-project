using Microsoft.EntityFrameworkCore;


namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class AddressRepository : IAddressRepository
    {
        private DatabaseContext _dbContext;

        private IEnumerable<Address> _address;


        public AddressRepository(DatabaseContext databaseContext)
        {
            _address = databaseContext.Address;
            _dbContext = databaseContext;

        }

        public Address? FindOne(Guid foundAddress)
        {
            Address? address = _address.FirstOrDefault(address => address.AddressId == foundAddress);
            return address;
        }

        public IEnumerable<Address> FindAll(Guid userId)
        {
            return _dbContext.Address
                .Where(address => address.UserId == userId)
                .ToList();
        }


        public Address CreateOne(Address address)
        {

            _address = _address.Append(address);
            return address;


        }
        public Address UpdateOne(Address updatedAddress)
        {
            var Addresses = _address.Select(address =>
        {
            if (address.Street == updatedAddress.Street)
            {

                return updatedAddress;
            }
            return updatedAddress;
        });
            _address = Addresses.ToList();

            return updatedAddress;
        }
    }

}