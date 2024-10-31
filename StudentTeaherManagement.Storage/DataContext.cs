using Microsoft.EntityFrameworkCore;
using StudentTeacherManagement.Core.Models;

namespace StudentTeaherManagement.Storage;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
}