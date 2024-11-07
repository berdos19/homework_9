using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc.Filters;

namespace StudentTeacherManagement;

public class LogFilter : Attribute, IAsyncActionFilter
{
    private readonly string _name;
    public LogFilter([CallerMemberName]string? name = null)
    {
        _name = name;
    }
    
    // before endpoint
    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        Console.WriteLine($"Before endpoint [{_name}({string.Join(", ", context.ActionArguments.Keys)})]");
        await next.Invoke();
    }

    
    //after endpoint
    /*public void OnActionExecuted(ActionExecutedContext context)
    {
        Console.WriteLine($"After endpoint {string.Join(", ", context.ActionDescriptor.Parameters.Select(x => $"{x.Name}:{x.ParameterType.Name}"))}");
    }*/
}