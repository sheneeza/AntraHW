namespace HW3;

public class Department
{
    public string Name { get; set; }
    public string DepartmentHead { get; set; }
    public decimal Budget { get; set; }
    private List<Course> _courses;
    public List<Course> Courses { get => _courses; set => _courses = value; }
}