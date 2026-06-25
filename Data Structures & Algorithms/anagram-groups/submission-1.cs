public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);

            string key = new string(charArray);

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
