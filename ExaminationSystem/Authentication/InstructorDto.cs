﻿namespace ExaminationSystem.Authentication;

public class RegisterInstructorDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; } // Add this property
}
