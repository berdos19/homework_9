using System.Text;
using System.Text.RegularExpressions;

namespace StudentTeacherManagement;

public class ForbiddenWordsMiddleware
{
    private static readonly string[] _forbiddenWords = ["word1", "word2", "word3"];

    private readonly RequestDelegate _next;

    public ForbiddenWordsMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        context.Request.EnableBuffering();
        var body = await new StreamReader(context.Request.Body).ReadToEndAsync();
        var validatedBody = Regex.Replace(body, string.Join("|", _forbiddenWords), "***");

        var stream = new MemoryStream(Encoding.UTF8.GetBytes(validatedBody));

        context.Request.Body = stream;
        context.Request.Body.Position = 0;
        
        await _next.Invoke(context);
    }
}