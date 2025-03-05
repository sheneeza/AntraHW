namespace HW3;

public interface IPersonService<TPerson> where TPerson : Person
{
    int CalculateAge(int age);
    decimal CalculateSalary(decimal salary);
}