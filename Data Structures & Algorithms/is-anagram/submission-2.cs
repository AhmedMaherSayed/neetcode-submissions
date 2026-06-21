public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        var sDic = new Dictionary<char, int>();
        var tDic = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            sDic[s[i]] = sDic.GetValueOrDefault(s[i], 0) + 1;
            tDic[t[i]] = tDic.GetValueOrDefault(t[i], 0) + 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (!sDic.TryGetValue(t[i], out int sValue))
                return false;
            
            if (tDic[t[i]] != sValue)
                return false;
        }

        return true;
    }
}
