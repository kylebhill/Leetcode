public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
                return "";
        string result = "";
        foreach(string s in strs)
        {
            if(s == strs[0])
            {
                result = s;
                continue;
            }
            else if(result[0] != s[0])
                return "";
            else if(result.Length > s.Length)
                result = result.Remove(s.Length);
            for(int i = 1; i<result.Length; i++)
            {
                if(result[i] != s[i])
                {
                    result = result.Remove(i);
                    break;
                }
            }
        }
        return result;
    }
}