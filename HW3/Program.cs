// See https://aka.ms/new-console-template for more information

using HW3;

Console.WriteLine("Hello, World!");

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Reverse contents of an array.");
WorkingWithMethods wm = new WorkingWithMethods();
int[] arr = wm.GenerateNumbers(10);
Console.WriteLine("Before reversal.");
wm.PrintNumbers(arr);
wm.Reverse(arr);
Console.WriteLine();
Console.WriteLine("After reversal.");
wm.PrintNumbers(arr);
Console.WriteLine();

Console.WriteLine("------------------------------------------------");
Console.WriteLine("First 10 numbers in the Fibonacci sequence:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Fibonacci({i}) = {wm.Fibonacci(i)}");
}

Console.WriteLine("------------------------------------------------");

Student student = new Student();
student.Name = "James";
Console.WriteLine($"Student Name: {student.Name}");
student.SalaryCalculation();

Instructor instructor = new Instructor();
instructor.Name = "Sarah";
Console.WriteLine($"Instructor Name: {instructor.Name}");
instructor.SalaryCalculation();

Console.WriteLine("------------------------------------------------");

Ball redBall = new Ball(5.5, new Color(255, 0, 0));
Ball blueBall = new Ball(7.0, new Color(0, 0, 255));
Ball greenBall = new Ball(6.0, new Color(0, 255, 0));

redBall.ThrowBall();
redBall.ThrowBall();
blueBall.ThrowBall();
greenBall.ThrowBall();
greenBall.ThrowBall();
greenBall.ThrowBall();

Console.WriteLine();

redBall.Pop();
greenBall.Pop();

Console.WriteLine();

redBall.ThrowBall();
greenBall.ThrowBall();

Console.WriteLine();

Console.WriteLine($"Red ball throws: {redBall.GetThrowCounter()}");
Console.WriteLine($"Blue ball throws: {blueBall.GetThrowCounter()}");
Console.WriteLine($"Green ball throws: {greenBall.GetThrowCounter()}");

Console.WriteLine("\nFinal Ball States:");
Console.WriteLine(redBall);
Console.WriteLine(blueBall);
Console.WriteLine(greenBall);
