using FarmManagement.BL;
using FarmManagement.UI.Web.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FarmManagement.UI.Web.Controllers.Api;

[ApiController]
[Route("api/[controller]")]
public class FarmsController : ControllerBase
{
    private readonly IManager _manager;

    public FarmsController(IManager manager)
    {
        _manager = manager;
    }


    [Route("GetFarmsOfAnimal/{animalId}")]
    [HttpGet]
    public IActionResult GetFarmsOfAnimal(int animalId)
    {
        var farms = _manager.GetFarmsOfAnimal(animalId);
        return Ok(farms);
    }

    [Route("GetAvailableFarmsOfAnimal/{animalId}")]
    [HttpGet]

    public IActionResult GetAvailableFarmsOfAnimal(int animalId)
    {
        var farms = _manager.GetAvailableFarmsOfAnimal(animalId);
        
        return Ok(farms);
    }

    [Route("CreateFarmAnimal")]
    [HttpPost]

    public IActionResult Post(newFarmAnimalDto newFarmAnimal)
    {
        var farmAnimal = _manager.AddFarmAnimal(newFarmAnimal.FarmId, newFarmAnimal.AnimalId, newFarmAnimal.Count);
        return Ok();
    }
}