using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace sda_onsite_2_csharp_backend_teamwork_The_countryside_developers.Controllers;



[ApiController]

[Route("[controller]")]

public class TestController : ControllerBase
{

    private List<User> _users;
    [HttpGet]

    public string SayHi()
    {
        var helloService = new HelloSerivce();
        return helloService.SayHi();
    }

    [HttpGet]
    public List<User> findAll()
    {
        return _users;

    }

    [HttpPost]

    public string PostTest(string message)
    {

        var post = new HelloSerivce();
        return post.PostService(message);
    }



}

public class HelloSerivce()
{

    public string SayHi()
    {
        string message = "Hi";
        return message;
    }



    public string PostService(string message)
    {

        string theStringIs = (message);
        return theStringIs;
    }
}


public class User{
    
    public string name;
    public int id;
    public string password;

    public User(string name, int id, string password){
        this.name = name;
        this.id = id;
        this.password = password;

    }

}