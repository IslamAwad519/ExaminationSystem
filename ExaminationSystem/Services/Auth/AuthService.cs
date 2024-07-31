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

    public async Task<ResponseDto?> LoginAsync(string email, string password)
    {
        // check user
        var user = await _userManager.FindByEmailAsync(email);
        if (user is null)
            return null;

        //check password
        var isValidPasword = await _userManager.CheckPasswordAsync(user, password);
        if (!isValidPasword)
            return null;

        //var roles = await _userManager.GetRolesAsync(user);
        //user.Roles = roles;

        //generate jet token
        var (token, expiresIn) = _jwtProvider.GenerateToken(user);

        // return response 
        return new ResponseDto(user.Id, user.Email, token, expiresIn);

    }
    public async Task<ResponseDto> RegisterAsync(RegisterDto registerDto)
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
            // Determine role based on the RegisterDto
            //string role = registerDto.Default;
            //if (string.IsNullOrEmpty(registerDto.Role)
            //{
            //    role = DefaultRoles.Student; // Default role if none provided
            //}

            // Add the user to the role by name
           // await _userManager.AddToRoleAsync(user, registerDto.Role.ToString());

            // Generate JWT token
            var (token, expiresIn) = _jwtProvider.GenerateToken(user);

            // Return response
            return new ResponseDto(user.Id, user.Email, token, expiresIn);
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
