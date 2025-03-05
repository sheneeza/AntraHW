namespace HW3;

public abstract class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public decimal Salary { get; set; }

    public abstract void SalaryCalculation();
}

public class Student : Person
{
    public int StudentId { get; set; }
    public String Grade { get; set; }
    private List<String> courses = new();

    public List<String> getCourses()
    {
        return courses;
    }

    public void addCourse(string course)
    {
        courses.Add(course);
    }
    
    public override void SalaryCalculation()
    {
        Console.WriteLine("Calculate Student's Salary");
    }
}

public class Instructor : Person
{
    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public DateOnly Joined { get; set; }
    
    public override void SalaryCalculation()
    {
        Console.WriteLine("Calculate Instructor's Salary");
    }
}

public class DepatmentHead : Instructor
{
    public decimal Salary { get; set; }
}