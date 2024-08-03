using ExaminationSystem.Authentication;
using ExaminationSystem.DTOs.Auth;

namespace ExaminationSystem.Services.Auth;

public interface IAuthService
{
    Task<AuthResponse?> LoginAsync(string email, string password);
    Task<AuthResponse?> RegisterAsync(RegisterDto registerDto);
}
