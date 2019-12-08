/*Runtime: 40 ms, faster than 85.35% of C# online submissions for Reverse Integer.
Memory Usage: 14.1 MB, less than 8.33% of C# online submissions for Reverse Integer.*/
public class Solution
{
    public int Reverse(int x)
    {
        int rev = 0;
        while (x != 0)
        {
            if (Math.Abs(rev) > int.MaxValue / 10) return 0;
            rev = rev * 10;
            rev = rev + (x % 10);
            x = x / 10;
        }
        return rev;
    }
}