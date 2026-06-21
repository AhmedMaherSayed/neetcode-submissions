public class Solution {
    public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
                return false;

            var sDic = new Dictionary<char, int>();
            var tDic = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (sDic.ContainsKey(s[i]))
                {
                    sDic[s[i]] += 1;
                }
                else
                {
                    sDic.Add(s[i], 1);
                }

                if (tDic.ContainsKey(t[i]))
                {
                    tDic[t[i]] += 1;
                }
                else
                {
                    tDic.Add(t[i], 1);
                }
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
