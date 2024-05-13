using Microsoft.AspNetCore.Mvc;
namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{

    public class AddressController : ControllerTemplate
    {

        private AddressService _addressService;

        public AddressController(AddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("userId")]

        //getall by user id

        public Address FindAll(Guid userId)
        {
            return _addressService.FindAll(userId);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


        //post 
        public ActionResult<Address> CreateOne([FromBody] Address address)
        {
            if (address is not null)
            {
                var createdAddress = _addressService.CreateOne(address);
                return CreatedAtAction(nameof(CreateOne), createdAddress);
            }
            return BadRequest();
        }


        //update

        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public Address? UpdateOne(Guid addressId, [FromBody] Address Address)
        {

            if (Address is not null)
            {
                return _addressService.UpdateOne(addressId, Address);

            }
            return null;
        }

    }


    //delete one by address id












}






