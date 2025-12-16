// See https://aka.ms/new-console-template for more information
int[] arr= { 4, 1, 2, 1, 2 };
Console.WriteLine(Solution.SingleNumber(arr));
Console.ReadLine();
//https://leetcode.com/problems/single-number/
public static class Solution
{
    public static int SingleNumber(int[] nums)
    {
        int ans = 0;
        foreach (int val in nums)
        {
            ans ^= val;
        }
        return ans;
    }
}