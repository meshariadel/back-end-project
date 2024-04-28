using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Entites;
using sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Repositories;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Services;



public class UserService
{

    public List<OrderItem> FindAll()
    {
        var servicesFindAll = new Repository();

        return servicesFindAll.FindAll();
    }


}