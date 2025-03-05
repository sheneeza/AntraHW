namespace HW3;

public interface ICourseService<T> where T : class
{
    void AddCourse(T course);
    void RemoveCourse(T course);
    void UpdateCourse(T course);
}