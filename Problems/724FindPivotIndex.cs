namespace Problems;
public class FindPivotIndex
{
    /// <summary>
    /// pivot is index where 0-n indexes sum == n+1-n.Length
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public int PivotIndex(int[] nums)
    {

        var sumLeft = 0;
        var sumRight = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            //subtract the current index to get i+1 to last
            //this also corrects for the first index where it should be 0 on the right
            sumRight -= nums[i];
            //we've got the pivot
            if (sumLeft == sumRight)
            {
                return i;
            }
            //rolling sum till we hit the end
            sumLeft += nums[i];
        }

        return -1;
    }
}