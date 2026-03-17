namespace apbd_cw1_git_s31225;

public class StatisticsHelper
{
    public static double CalculateAverage(int[] nums)
    {
        int sum = 0;
        foreach (int num in nums)
        {
            sum += num;
        }
        return (double) sum / nums.Length;
    }
}