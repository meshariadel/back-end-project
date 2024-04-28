using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Databases;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Repositories;





public class Repository
{
    private List<OrderItem> _orderitems;
    public Repository()
    {
        _orderitems = new DatabaseContext().order_item;
    }

    public List<OrderItem> FindAll()
    {
        Console.WriteLine("test");
        return _orderitems;
    }


}