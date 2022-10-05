using namespace std;
#include <string> 
//I use these implicitly in my solution

class Solution {
public:
    bool isPalindrome(int x) {
        string s = to_string(x);
        int n = s.length()-1;
        int i = 0;
        while(i<=n)
        {
            swap(s[i], s[n]);
            n-= 1;
            i+= 1;
        }
        if (s == to_string(x))
            return true;
        else
            return false;
    }
};