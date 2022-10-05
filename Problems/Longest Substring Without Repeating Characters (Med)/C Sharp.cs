public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
        int maxSubstring = 1;
        if(s.Length<1)
        {
            return 0;
        }
        for(int i = 0; i<s.Length-1; i++)
        {
            for(int n = i+1; n< s.Length; n++)
            {
                bool br = false;
                String sub = s.Substring(i,n-i);
                foreach(char c in sub)
                {
                    if(s[n]==c)
                        br = true;
                }
                if(br)
                {
                    break;
                }
                maxSubstring = ((n+1-i)>maxSubstring)?(n+1-i):maxSubstring;
            }
            if(maxSubstring >= (s.Length- i))
                break;
        }
        return maxSubstring;
    }
}