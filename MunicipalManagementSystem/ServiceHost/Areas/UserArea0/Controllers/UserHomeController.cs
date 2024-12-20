using Microsoft.AspNetCore.Mvc;

namespace ServiceHost.Areas.UserArea.Controllers;

[Area("UserArea")]
public class UserHomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}