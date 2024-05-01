namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class OrderItem
    {

        public OrderItem(int quantity, decimal totalPirce)
        {
            Quantity = quantity;

            TotalPirce = totalPirce;

        }

        public string OrderItemId { get; } = Guid.NewGuid().ToString();
        public string OrderId { get; set; } = Guid.NewGuid().ToString();

        public string ProductId { get; set; } = Guid.NewGuid().ToString();

        public int Quantity { get; set; }

        public decimal TotalPirce { get; set; }

    }
}