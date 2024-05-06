using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    [Keyless]
    public class UserOrder
    {
        public string OrderId { get; set; }
        public string UserId { get; set; }
        public string PaymentId { get; set; }
        public string AddressId { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime DeliveryAt { get; set; }
        public OrderStatus Status { get; set; }

        public enum OrderStatus
        {
            Processing,
            Shipped,
            OutForDelivery,
            Delivered
        }

    }
}
