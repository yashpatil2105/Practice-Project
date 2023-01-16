using Microsoft.AspNetCore.Mvc;
using DAL;
using BOL;
namespace avatar.Controllers;

[ApiController]
[Route("[controller]")]
public class VehiclesController : ControllerBase
{
    
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<VehiclesController> _logger;

    public VehiclesController(ILogger<VehiclesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetVehicles")]
    public IEnumerable<Vehicle> Get()
    {
        IVehicleManager veh = new VehicleManager();
        List<Vehicle> v = veh.GetAll();
        return v;
    }
}
