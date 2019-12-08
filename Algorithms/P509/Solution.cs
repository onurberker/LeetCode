public class Solution {
    
    /*
    Runtime: 40 ms, faster than 75.45% of C# online submissions for Fibonacci Number.
Memory Usage: 14 MB, less than 8.33% of C# online submissions for Fibonacci Number
*/
    public int Fib(int N) {
        if(N<=1) return N;
        if(N==2) return 1;
        
        int n=0;
        int n1=1;
        int n2=1;
        
        for(int i=3;i<=N;i++)
        {
            n=n1+n2;
            n2=n1;
            n1=n;
        }
        return n;
    }
}