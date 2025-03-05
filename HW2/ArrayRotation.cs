namespace HW2;

public class ArrayRotation
{
    public int[] rotateSum (int[] array, int rotation)
    {
        int n = array.Length;
        int[] sumArray = new int[n];
        
        for (int r = 1; r <= rotation; r++)
        {
            int[] rotatedArray = RotateRight(array, r); 
            for (int i = 0; i < n; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
        }
        return sumArray;
    }
    
    static int[] RotateRight(int[] arr, int rotations)
    {
        int n = arr.Length;
        int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            rotated[(i + rotations) % n] = arr[i];
        }

        return rotated;
    }
}