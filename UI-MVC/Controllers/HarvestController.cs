using FarmManagement.BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.UI.Web.Controllers;

[AutoValidateAntiforgeryToken]
[Authorize]
public class HarvestController : Controller
{
    private readonly IManager _manager;

    public HarvestController(IManager manager)
    {
        _manager = manager;
    }
    
    [AllowAnonymous]
    public IActionResult Index()
    {
      return View();
    }
}