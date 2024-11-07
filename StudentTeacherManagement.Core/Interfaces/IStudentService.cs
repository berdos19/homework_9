using StudentTeacherManagement.Core.Models;

namespace StudentTeacherManagement.Core.Interfaces;

public interface IStudentService
{
    Task<IEnumerable<Student>> GetStudents(int skip, int take, CancellationToken cancellationToken = default);
    Task<Student?> GetStudentById(Guid id, CancellationToken cancellationToken = default);

    Task<Student> AddStudent(Student student, CancellationToken cancellationToken = default);
    Task<Student> UpdateStudent(Guid id, Student student, CancellationToken cancellationToken = default);
    Task<Student> DeleteStudent(Guid id, CancellationToken cancellationToken = default);
}