public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>(nums.Length);
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (seen.TryGetValue(complement, out int j))
                return [j, i];

            seen[nums[i]] = i;
        }
        return [];
    }
}
