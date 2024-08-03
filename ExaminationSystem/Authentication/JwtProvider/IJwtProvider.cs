using System.Data;

namespace ExaminationSystem.Authentication;

public interface IJwtProvider
{
    (string token, int expiresIn) GenerateToken(ApplicationUser user, IList<string> roles);
}