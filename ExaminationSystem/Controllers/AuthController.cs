using ExaminationSystem.DTOs.Auth;
namespace ExaminationSystem.Controllers;


[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto request)
    {
        var result = await _authService.LoginAsync(request.Email, request.Password);

        return result is null 
            ? BadRequest("Invalid email/password") 
            : Ok(result);
    }
    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto request)
    {
        var result = await _authService.RegisterAsync(request);

        return result is null
            ? BadRequest("Invalid email/password")
            : Ok(result);
    }
    [HttpPost("add-instructor")]
    public async Task<IActionResult> RegisterInstructor(RegisterDto request)
    {
        var result = await _authService.RegisterAsync(request);

        return result is null
            ? BadRequest("Invalid email/password")
            : Ok(result);
    }
}
