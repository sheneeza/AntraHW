namespace HW3;

public interface IStudentService<T> where T : Student, IPersonService<T>
{
    float CalculateGpa(T student);
    
}