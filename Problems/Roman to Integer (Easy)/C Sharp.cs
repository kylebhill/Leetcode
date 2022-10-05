public class Solution {
    public int RomanToInt(string s) {
        int sum = 0;
        char previous = '1';
        foreach(char c in s)
        {
            switch(c)
            {
                case 'I':
                    sum += 1;
                    break;
                case 'V':
                    if(previous == 'I')
                    {
                        sum -= 2;
                    } 
                    sum += 5;
                    break;
                case 'X':
                    if(previous == 'I')
                    {
                        sum -= 2;
                    }
                    sum += 10;
                    break;
                case 'L':
                    if(previous == 'X')
                    {
                        sum -= 20;
                    } 
                    sum += 50;
                    break;
                case 'C':
                    if(previous == 'X')
                    {
                        sum -= 20;
                    } 
                    sum += 100;
                    break;
                case 'D':
                    if(previous == 'C')
                    {
                        sum -= 200;
                    } 
                    sum += 500;
                    break;
                case 'M':
                    if(previous == 'C')
                    {
                        sum -= 200;
                    } 
                    sum += 1000;
                    break;
                default:
                    break;
            }
            previous = c;
        }
        return sum;
    }
}