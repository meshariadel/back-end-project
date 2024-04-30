
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.src.Entities;
public class UserOrderRepository : IUserOrderRepository
{
    private IEnumerable<UserOrder> _userOrder;

    public UserOrderRepository()
    {
        _userOrder = new UserOrderDatabaseContext().userOrder;
    }
    public IEnumerable<UserOrder> FindAll()
    {
        return _userOrder;
    }
    public IEnumerable<UserOrder> CreateOne(UserOrder userOrder)
    {
        _userOrder = _userOrder.Append(userOrder);
        return _userOrder;
    }
    public UserOrder? FindOne(UserOrder NewUserOrder)
    {
        UserOrder? userOrder = _userOrder.FirstOrDefault(userOrder => userOrder.OrderId == NewUserOrder.OrderId);

        return userOrder;
    }
    public UserOrder? FindOneById(string id)
    {
        UserOrder? userOrder = _userOrder.FirstOrDefault(userOrder => userOrder.OrderId == id);

        return userOrder;
    }



}
