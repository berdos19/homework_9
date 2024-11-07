namespace StudentTeacherManagement.Core.Interfaces;

public interface IEmailSender
{
    Task Send(string empty);
}