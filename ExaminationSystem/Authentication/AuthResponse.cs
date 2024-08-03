namespace ExaminationSystem.Authentication;

public record AuthResponse(
    string Id,
    string? Email,
    string Token,
    int ExpiresIn
);