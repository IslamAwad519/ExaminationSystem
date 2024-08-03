using ExaminationSystem.DTOs.Auth;
namespace ExaminationSystem.Services.Auth;

public class AuthService : IAuthService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IJwtProvider _jwtProvider;
    public AuthService(UserManager<ApplicationUser> userManager, IJwtProvider jwtProvider)
    {
        _userManager = userManager;
        _jwtProvider = jwtProvider;
    }

    public async Task<AuthResponse?> LoginAsync(string email, string password)
    {
        // check user
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null)
            return null;

        //check password
        var isValidPasword = await _userManager.CheckPasswordAsync(user, password);
        if (!isValidPasword)
            return null;

        var role = await _userManager.GetRolesAsync(user);
        //user.Roles = roles;

        //generate jet token
        var (token, expiresIn) = _jwtProvider.GenerateToken(user,role);

        // return response 
        return new AuthResponse(user.Id, user.Email, token, expiresIn);

    }
    public async Task<AuthResponse?> RegisterAsync(RegisterDto registerDto)
    {
        var user = new ApplicationUser
        {
            Email = registerDto.Email,
            UserName = registerDto.Email,
            FirstName = registerDto.FirstName,
            LastName = registerDto.LastName,
        };

        var result = await _userManager.CreateAsync(user, registerDto.Password);

        if (result.Succeeded)
        {
            var role = registerDto.Role ?? DefaultRoles.Student;
            await _userManager.AddToRoleAsync(user, role);

            // Generate JWT token
            // Create a list of roles containing the single role
            var roles = new List<string> { role };
            var (token, expiresIn) = _jwtProvider.GenerateToken(user, roles);

            // Return response
            return new AuthResponse(user.Id, user.Email, token, expiresIn);
        }

        return null;
    }

    //public async Task<ResponseDto> RegisterAsync(RegisterDto registerDto)
    //{

    //    var user = new ApplicationUser
    //    {
    //        Email = registerDto.Email,
    //        UserName = registerDto.Email,
    //        FirstName = registerDto.FirstName,
    //        LastName = registerDto.LastName,
    //    };

    //   var result =  await _userManager.CreateAsync(user,registerDto.Password);
    //    if(result.Succeeded)
    //    {
    //        // Add the user to the role by name
    //        await _userManager.AddToRoleAsync(user,DefaultRoles.Student);

    //        //generate jet token
    //        var (token, expiresIn) = _jwtProvider.GenerateToken(user);

    //        // return response 
    //        return new ResponseDto(user.Id, user.Email, token, expiresIn);
    //    }
    //    return null;
    //}

}
