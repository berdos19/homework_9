using StudentTeacherManagement.Core.Interfaces;
using StudentTeaherManagement.Storage;

namespace StudentTeacherManagement;

public class MyMiddleware
{
    private readonly RequestDelegate _next;
    
    public MyMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    
    public async Task InvokeAsync(HttpContext ctx)
    {
        var context = ctx.RequestServices.GetRequiredService<DataContext>();
        Console.WriteLine($"Middleware execution before next()");
        await _next.Invoke(ctx);
        Console.WriteLine($"Middleware execution after next()");
    }
}