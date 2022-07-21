public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = {0, 1};
        for(int a = 0; a < nums.Length-1; a++)
        {
            result[0] = a;
            for(int b = a+1; b < nums.Length; b++)
            {
                int test = nums[a] + nums[b];
                if(test == target)
                {
                    result[1] = b;
                    return result;
                }
            }
        }
        return result;
    }
}