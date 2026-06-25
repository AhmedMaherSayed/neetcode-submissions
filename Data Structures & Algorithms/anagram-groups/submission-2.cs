public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs)  // O: M
        {
            int[] count = new int[26];

            foreach (var c in str)  // O: N
            {
                count[c - 'a']++;
            }
            string key = string.Join(",", count);

            if (!groups.ContainsKey(key)) {
                groups[key] = new List<string>();
            }

            groups[key].Add(str);
        }

        List<List<string>> ans = new();

        foreach (var group in groups) {
            ans.Add(group.Value);
        }

        return ans;
    }
}
