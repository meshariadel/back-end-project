using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class AddressService : IAddressService
    {
        private AddressRepository _addressRepository;

        private IMapper _Mapper;


        public AddressService(AddressRepository AddressRepository, IMapper mapper)
        {

            _addressRepository = AddressRepository;

            _Mapper = mapper;
        }
        public Address FindAll(Guid userId)
        {
            return (Address)_addressRepository.FindAll(userId);
        }

        public Address? FindOne(Guid address)
        {
            var addressID = _addressRepository.FindOne(address);

            if (addressID is not null)
            {
                var addressMap = _Mapper.Map<Address>(addressID);
                return addressMap;
            }
            throw new Exception("Address Id " + addressID + " is not found ");
        }



        public Address CreateOne(Address address)
        {

            Address? foundAddress = _addressRepository.FindOne(address.AddressId);

            if (foundAddress is not null)
            {
                throw new Exception("Address " + address.AddressId + " already exists");
            }
            return _addressRepository.CreateOne(address);


        }



        public Address UpdateOne(Guid foundAddress, Address updatedAddress)
        {
            Address? address = _addressRepository.FindOne(foundAddress);
            if (address is not null)
            {
                address.Street = updatedAddress.Street;
                return _addressRepository.UpdateOne(address);

            }
            Console.WriteLine("Address " + foundAddress + " do not exists");
            return null;
        }

    }


}

