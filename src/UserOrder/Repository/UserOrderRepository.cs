
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;
public class UserOrderRepository : IUserOrderRepository
{
    private List<UserOrder> _userOrder;

    public UserOrderRepository()
    {
        _userOrder = new UserOrderDatabaseContext().userOrder;
    }
    public List<UserOrder> FindAll()
    {
        return _userOrder;
    }
    public List<UserOrder> CreateOne(UserOrder userOrder)
    {
        _userOrder.Add(userOrder);
        return _userOrder;
    }



}
