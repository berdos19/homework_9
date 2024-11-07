using Microsoft.EntityFrameworkCore;
using StudentTeacherManagement.Core.Interfaces;
using StudentTeacherManagement.Core.Models;
using StudentTeaherManagement.Storage;

namespace StudentTeacherManagement.Services;

public class GroupService : IGroupService
{
    private readonly DataContext _context;

    public GroupService(DataContext context)
    {
        _context = context;
    }

    #region DQL

    public async Task<IEnumerable<Group>> GetGroups(string? name, int skip, int take, CancellationToken cancellationToken = default)
    {
        var groups = _context.Groups.AsQueryable();

        if (!string.IsNullOrEmpty(name))
        {
            groups = groups.Where(g => g.Name.Contains(name));
        }

        return await groups.OrderBy(g => g.Name)
            .Skip(skip)
            .Take(take)
            .ToArrayAsync(cancellationToken);
    }

    public Task<Group?> GetGroupById(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region DML

    public Task<Group> AddGroup(Group group, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteGroup(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task AddStudentToGroup(Guid groupId, Guid studentId, CancellationToken cancellationToken = default)
    {
        var student = await _context.Students.FindAsync([studentId], cancellationToken: cancellationToken);
        student.GroupId = groupId;
        await _context.SaveChangesAsync(cancellationToken);
    }

    #endregion
}