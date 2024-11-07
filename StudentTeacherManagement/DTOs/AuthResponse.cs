using StudentTeacherManagement.Core.Models;

namespace StudentTeacherManagement.DTOs;

public class AuthResponse
{
    public User User { get; set; }
    public string Token { get; set; }
}