using StudentTeacherManagement.Core.Interfaces;

namespace StudentTeacherManagement.Fakes;

public class FakeEmailSender : IEmailSender
{
    public async Task Send(string message)
    {
        Console.WriteLine("*** FakeEmail sender: " + message + " ***");
    }
}