#include <string>
using namespace std;

class Solution {
public:
    string convert(string s, int numRows) 
    {
        if(numRows == 1)
            return s;

        string out = s;
        int index = 0;
        int mod = (numRows-1)*2;
        int size = s.size();
        int aproxNum = ((size-1)/mod)+1;
        for(int m = mod; m>=mod/2;m--)
        {
            for(int i = 0; i < aproxNum; i++)
            {
                if(m != mod && m!= mod/2)
                {
                    if(i*mod+mod-m < size)
                    {
                        out[index+i] = s[(i*mod+mod-m)];
                        index++;
                    }
                    else
                    {
                        index += i;
                        break;
                    }
                    if(i*mod+m < size)
                    {
                        out[index+i] = s[(i*mod+m)];
                    }
                    else
                    {
                        index += i;
                        break;
                    }
                
                }
                else if(m == mod/2)
                {
                    if(i*mod+m < size)
                    {
                        out[index+i] = s[(i*mod+m)];
                    }
                }
                else
                {
                    out[index+i] = s[(i*mod)];
                }
                if(i == aproxNum-1)
                {
                    index += i+1;
                }
            }
        }
        return out;
    }
};