using System.Collections;
public class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        Dictionary<int, int> d = new Dictionary<int, int>();
        var total = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(nums[i]))
            {
                d[nums[i]]++;
                total += d[nums[i]];
            }
            else d.Add(nums[i], 0);
        }
        return total;
    }
}