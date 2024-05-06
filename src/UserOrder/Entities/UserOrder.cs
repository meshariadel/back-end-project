namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserOrder
    {
        public string OrderId { get; set; } = Guid.NewGuid().ToString();
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string PaymentId { get; set; } = Guid.NewGuid().ToString();
        public string AddressId { get; set; } = Guid.NewGuid().ToString();

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime DeliveryAt { get; set; }
        public OrderStatus Status { get; set; }

        /* public UserOrder(string orderId, string userId, string paymentId, string addressId, DateTime createdAt, DateTime deliveryAt, OrderStatus status)
          {
              OrderId = orderId;
              UserId = userId;
              PaymentId = paymentId;
              AddressId = addressId;
              CreatedAt = createdAt;
              DeliveryAt = deliveryAt;
              Status = status;

          }
          */
        public enum OrderStatus
        {
            Processing,
            Shipped,
            OutForDelivery,
            Delivered
        }

    }
}
