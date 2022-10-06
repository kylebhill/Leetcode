#include <string>
using namespace std;

class Solution {
public:
    int reverse(int x) {
        string s = to_string(x);
        int n = s.size()-1;
        int i = (x>=0)?0:1;
        while(i<=n)
        {
            swap(s[i], s[n]);
            n--;
            i++;
        }
        try
        { 
            return stoi(s);
        }
        catch(...)
        {
            return 0;
        }
    }
    int altReverse(int x)
    {
        int out = 0;
        while(x!=0) 
        {
            try
            {      
                out = out * 10 + (x % 10);
                x /= 10;
            }
            catch(...)
            {
                return 0;
            }      
        }
        return out;
    }
};

