namespace Problems;

public class BinarySearch
{
    public int Search(int[] nums, int target) {
        
        //this is the way you do it for work because duh
        // var i = Array.BinarySearch(nums,target);
        // return (i<0) ? -1 : i;
        
        var min = 0;
        var max = nums.Length -1;
        while (min<=max)
        {
            var mid = min + (max-min)/2;
            if(nums[mid]==target)
                return mid;
            if(nums[mid]>target)
                max = mid -1;
            else
                min = mid +1;
        }
        return -1;
    }
}