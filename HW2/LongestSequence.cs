namespace HW2;

public class LongestSequence
{
    public int[] FindLongestSequence(int[] array)
    {
        int longestStart = 0;
        int longestLength = 1;
        int currentStart = 0;
        int currentLength = 1;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1]) // If same as previous element
            {
                currentLength++;
            }
            else
            {
                // If current sequence is longer than longest found so far
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    longestStart = currentStart;
                }

                // Reset for next sequence
                currentStart = i;
                currentLength = 1;
            }
        }
        
        if (currentLength > longestLength)
        {
            longestLength = currentLength;
            longestStart = currentStart;
        }
        
        List<int> longestSequence = new List<int>();
        for (int i = longestStart; i < longestStart + longestLength; i++)
        {
            longestSequence.Add(array[i]);
        }
        
        return longestSequence.ToArray();
    }
}