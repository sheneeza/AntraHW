namespace HW3;

public class Course
{
    private List<Student> students;

    public List<Student> GetStudents()
    {
        return students;
    }

    public void AddStudent(Student student)
    {
        students.Add(student);
    }
}