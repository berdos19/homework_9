using StudentTeacherManagement.Core.Models;

namespace StudentTeacherManagement.Core.Interfaces;

public interface IGroupService
{
    // DQL - Data Query Language
    Task<IEnumerable<Group>> GetGroups(string? name, int skip, int take, CancellationToken cancellationToken = default);
    Task<Group?> GetGroupById(Guid id, CancellationToken cancellationToken = default);
    
    // DML - Data Manipulation Language
    Task<Group> AddGroup(Group group, CancellationToken cancellationToken = default);
    Task DeleteGroup(Guid id, CancellationToken cancellationToken = default);
    Task AddStudentToGroup(Guid groupId, Guid studentId, CancellationToken cancellationToken = default);
    
    // DDL = Data Definition Language
    // TCL - Transaction Control Language
}