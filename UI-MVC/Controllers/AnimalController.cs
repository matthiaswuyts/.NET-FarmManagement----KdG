using FarmManagement.BL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.UI.Web.Controllers;

[AutoValidateAntiforgeryToken]
[Authorize]
public class AnimalController : Controller
{
    private readonly IManager _manager;

    public AnimalController(IManager manager)
    {
        _manager = manager;
    }
    
    [HttpGet]
    [AllowAnonymous]
    public IActionResult Details(int id)
    {
        var animal = _manager.GetAnimal(id);
        return View(animal);
    }
}