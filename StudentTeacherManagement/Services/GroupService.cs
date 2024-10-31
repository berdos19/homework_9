using StudentTeacherManagement.Core.Interfaces;
using StudentTeacherManagement.Core.Models;

namespace StudentTeacherManagement.Services;

public class GroupService : IGroupService
{
    #region DQL

    public Task<IEnumerable<Group>> GetGroups(string? name, int skip, int take, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
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

    public Task AddStudentToGroup(Guid groupId, Guid studentId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    #endregion
}