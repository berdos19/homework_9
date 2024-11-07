using StudentTeacherManagement.Core.Models;

namespace StudentTeacherManagement.Core.Interfaces;

public interface IAuthService
{
    Task Register(User user);
    Task<User?> Login(string email, string password);

    Task<User> ValidateAccount(string email, int code);
}