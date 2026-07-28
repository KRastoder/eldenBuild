using Microsoft.AspNetCore.Mvc;

namespace EldenBuilds.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    [HttpPost]
    public IActionResult GetProst()
    {
        return Ok();
    }

}
