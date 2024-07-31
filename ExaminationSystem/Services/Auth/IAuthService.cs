using ExaminationSystem.Authentication;
using ExaminationSystem.DTOs.Auth;

namespace ExaminationSystem.Services.Auth;

public interface IAuthService
{
    Task<ResponseDto?> LoginAsync(string email, string password);
    Task<ResponseDto?> RegisterAsync(RegisterDto registerDto);
}
