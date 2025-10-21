using Microsoft.AspNetCore.Mvc;

namespace register_user_backend_dotnet.Controllers;

public class UserController : Controller
{

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    
}