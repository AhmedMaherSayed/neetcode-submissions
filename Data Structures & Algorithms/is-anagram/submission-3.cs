public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var freq = new int[26];

        for (int i = 0; i < s.Length; i++) {
            freq[s[i] - 'a']++;
            freq[t[i] - 'a']--;
        }

        foreach (int num in freq) {
            if (num != 0)
                return false;
        }

        return true;
    }
}
