using Microsoft.EntityFrameworkCore;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers
{
    public class UserOrderRepository : IUserOrderRepository
    {
        private DbSet<UserOrder> _userOrder;
        private DatabaseContext _dbContext;
        public UserOrderRepository(DatabaseContext dbContext)
        {
            _userOrder = dbContext.UserOrder;
            _dbContext = dbContext;
        }
        public IEnumerable<UserOrder> FindAll()
        {
            return _userOrder;
        }
        public IEnumerable<UserOrder> CreateOne(UserOrder userOrder)
        {
            _userOrder.Add(userOrder);
            _dbContext.SaveChanges();
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
        public UserOrder? UpdateOne(UserOrder updateUserOrder)
        {
            _userOrder.Update(updateUserOrder);
            _dbContext.SaveChanges();
            return updateUserOrder;
        }
    }
}
