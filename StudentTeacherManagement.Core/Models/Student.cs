namespace StudentTeacherManagement.Core.Models;

public class Student : User
{
    /// <summary>
    ///  When student enrolled on a course
    /// </summary>
    public DateTime EnrolledAt { get; set; }

    public virtual Group Group { get; set; }
    
}