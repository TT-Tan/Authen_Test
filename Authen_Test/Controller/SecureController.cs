using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Authen_Test.Controller;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetSecureData()
    {
        return Ok(new { Data = "This is a secure endpoint!"});
    }
}