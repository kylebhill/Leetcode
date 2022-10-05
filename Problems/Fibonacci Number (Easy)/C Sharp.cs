public class Solution {
    public int Fib(int n) {
        int sum = 0;
        int a = 0;
        int b = 1;
        if(n == 0)
            return 0;
        for(int i=1; i<=n; i++)
        {
            sum = a+b;
            if(i%2 == 0)
                a = sum;
            else
                b = sum;
        }
        return sum;
    }
}