namespace HW3;

public class WorkingWithMethods
{
    public int[] GenerateNumbers(int count)
    {
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            numbers[i] = i + 1;
        }
        return numbers;
    }

    public int[] Reverse(int[] numbers)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left < right)
        {
            (numbers[right], numbers[left]) = (numbers[left], numbers[right]);
            left++;
            right--;
        }
        return numbers;
    }

    public void PrintNumbers(int[] numbers)
    {
        //Console.WriteLine(string.Join(", ", numbers));
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
    
    public int Fibonacci(int n)
    {
        if (n <= 0) throw new ArgumentException("Input must be a positive integer.");
        if (n == 1) return 1; // First Fibonacci number
        if (n == 2) return 1; // Second Fibonacci number

        int a = 1, b = 1, result = 0;

        for (int i = 3; i <= n; i++)
        {
            result = a + b;
            a = b;
            b = result;
        }

        return result;
    }
    
    
}