namespace apbd_cw1_git_s31225;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty!");
        }
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return (double) sum / nums.Length;
    }

    public static double CalculateMax(int[] values)
    {
        if (values == null || values.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty!");
        }
        int max = values[0];
        for (int i = 0; i < values.Length; i++)
        {
            if (values[i] > max)
            {
                max = values[i];
            }
        }
        return max;
    }

    public static double CalculateMin(int[] numbers)
    {
        
    }
    
}