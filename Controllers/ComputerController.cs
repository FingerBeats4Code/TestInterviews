using Microsoft.AspNetCore.Mvc;

namespace thesis_exercise.Controllers;

[ApiController]
[Route("[controller]")]
public class ComputerController : ControllerBase
{

    private readonly IConfiguration configuration;

    public ComputerController(IConfiguration configuration)
    {
        this.configuration = configuration;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        return new JsonResult("GET");
    }

    [HttpPost]
    public async Task<IActionResult> Post()
    {
        return new JsonResult("POST");
    }
}
