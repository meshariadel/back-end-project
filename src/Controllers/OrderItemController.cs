using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Services;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Controllers;



[ApiController]

[Route("[controller]")]

public class OrderItemController : ControllerBase
{
[HttpGet]

public List<OrderItem> FindAll()
{
    var controllFindAll = new UserService();

    return controllFindAll.FindAll();
}


}

