namespace HW2;

public class MostFrequentNumber
{
    public void FindMostFrequentNumber(int[] numbers)
    {
        Dictionary<int, int> frequentNumbers = new Dictionary<int, int>();
        
        int mostFrequentNumber = numbers[0];
        int highestFrequency = 0;
        
        foreach (int num in numbers)
        {
            // Update frequency count
            if (!frequentNumbers.ContainsKey(num))
                frequentNumbers[num] = 0;
            
            frequentNumbers[num]++;

            // Update most frequent number (leftmost if tie)
            if (frequentNumbers[num] > highestFrequency)
            {
                highestFrequency = frequentNumbers[num];
                mostFrequentNumber = num;
            }
        }
        Console.WriteLine($"\nMost frequent number: {mostFrequentNumber} (occurs {highestFrequency} times)");
    }
}