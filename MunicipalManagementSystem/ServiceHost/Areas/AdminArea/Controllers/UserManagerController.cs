using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Areas.AdminArea.Controllers;

[Area("AdminArea")]
public class UserManagerController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}