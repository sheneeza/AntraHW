namespace HW3;

public interface IInstructorService<TInstructor> where TInstructor : Instructor, IPersonService<TInstructor>
{
    int YearsOfExperience (DateOnly dateJoined);
}