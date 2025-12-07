using FarmManagement.BL;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.UI.Web.Controllers;

public class AnimalController : Controller
{
    private readonly IManager _manager;

    public AnimalController(IManager manager)
    {
        _manager = manager;
    }
    
    [HttpGet]
    public IActionResult Details(int animalId)
    {
        var animal = _manager.GetAnimal(animalId);
        return View(animal);
    }
}