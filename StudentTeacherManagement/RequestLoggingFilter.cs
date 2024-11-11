using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;

namespace StudentTeacherManagement;

public class RequestLoggingFilter : IActionFilter
{
    private readonly ILogger<RequestLoggingFilter> _logger;

    public RequestLoggingFilter(ILogger<RequestLoggingFilter> logger)
    {
        _logger = logger;
    }

    public void OnActionExecuted(ActionExecutedContext context)
    {
    }

    public void OnActionExecuting(ActionExecutingContext context)
    {
        var request = context.HttpContext.Request;
        var sb = new StringBuilder();

        sb.AppendLine("Request Information:");
        sb.AppendLine($"Path: {request.Path}");
        sb.AppendLine($"Method: {request.Method}");
        sb.AppendLine($"QueryString: {request.QueryString}");

        foreach (var header in request.Headers)
        {
            sb.AppendLine($"Header: {header.Key} = {header.Value}");
        }

        if (request.HasFormContentType)
        {
            sb.AppendLine("Form Data:");
            foreach (var form in request.Form)
            {
                sb.AppendLine($"{form.Key} = {form.Value}");
            }
        }

        _logger.LogInformation(sb.ToString());
    }
}
