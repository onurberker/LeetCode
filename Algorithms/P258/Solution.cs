/*Runtime: 36 ms, faster than 96.36% of C# online submissions for Add Digits.
Memory Usage: 14.1 MB, less than 50.00% of C# online submissions for Add Digits.*/

public class Solution {
    public int AddDigits(int num) {
        int sum = 0;
        int sum2 = 0;
        int sum3=0;
        if (num < 0) return 0;
        else{
          
            while(num!=0)
            {
                sum = sum + (num % 10);
                num = num / 10; 
            }
            if(sum<10) return sum;
            else
            {
                while(sum!=0)
                {
                  sum2 = sum2 + (sum % 10);
                  sum = sum / 10;  
                }
                
            } 
        }
        if(sum2<10) return sum2; 
        else
        {
            while(sum2!=0)
            {
                sum3=sum3+(sum2%10);
                sum2=sum2/10;
            }
        }
        return sum3;
    }
}