namespace Problems;

public class RunningSumOfOneDArray 
{
    public int[] RunningSum(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums;
        }
        for(var i = 1; i<nums.Length;i++)
        {
            nums[i] += nums[i - 1];
        }
        return nums;
    } 
}