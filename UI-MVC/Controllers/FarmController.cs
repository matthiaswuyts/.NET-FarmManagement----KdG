using FarmManagement.BL;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.UI.Web.Controllers;

public class FarmController : Controller
{
    private readonly IManager _manager;

    public FarmController(IManager manager)
    {
        _manager = manager;
    }
    public IActionResult Index()
    {
        var farms = _manager.GetAllFarms();
        return View(farms);
    }

    public IActionResult Add()
    {
        return View();
    }

    public IActionResult Details(int farmId)
    {
        var farm = _manager.GetFarm(farmId);
        return View(farm);
    }
}