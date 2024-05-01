namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public interface IUserOrderService
    {
        public IEnumerable<UserOrder> FindAll();
        public IEnumerable<UserOrder> CreateOne(UserOrder userOrder);
        public UserOrder? FindOneById(string id);



    }
}