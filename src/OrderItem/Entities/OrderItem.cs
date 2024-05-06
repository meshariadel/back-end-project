namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItem
    {


        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public UserOrder UserOrder { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPirce { get; set; }



    }
}