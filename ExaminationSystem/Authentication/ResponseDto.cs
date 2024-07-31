namespace ExaminationSystem.Authentication;

public record ResponseDto(
    string Id,
    string? Email,
    string Token,
    int ExpiresIn
);