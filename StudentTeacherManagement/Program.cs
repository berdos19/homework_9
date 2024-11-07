using Microsoft.EntityFrameworkCore;
using StudentTeacherManagement;
using StudentTeacherManagement.Core.Interfaces;
using StudentTeacherManagement.Fakes;
using StudentTeacherManagement.Services;
using StudentTeaherManagement.Storage;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(opt =>
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Local")));
builder.Services.AddTransient<IEmailSender, FakeEmailSender>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddControllers();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

/*app.UseMiddleware<MyMiddleware>();
app.UseMiddleware<ForbiddenWordsMiddleware>();*/

app.MapControllers();


/*app.Use(async (ctx, next) => 
{
    Console.WriteLine($"My middleware: {ctx.Request.Path}");
    await next.Invoke(ctx);
});*/

app.Run();