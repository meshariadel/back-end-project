namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItem
    {


        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPirce { get; set; }



    }
}