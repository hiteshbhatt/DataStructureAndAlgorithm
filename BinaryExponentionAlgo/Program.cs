// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.Pow(2,-8));
Console.ReadLine();

//Implement pow(x, n), which calculates x raised to the power n (i.e., xn).


public static class Solution
{
    public static double Pow(int x, int n)
    {
        if (n == 0)
        {
            return 1.0;
        }
        if (x == 0)
        {
            return 0.0;
        }
        if (x == 1)
        {
            return 1.0;
        }
        if (x == -1 && n % 2 == 0) return 1.0;
        if (x == -1 && n % 2 != 0) return -1.0;

        long binaryForm = n;
        if (n < 0)
        {
            binaryForm = -binaryForm;
            x = 1 / x;

        }

        double ans = 1;
        while (binaryForm > 0)
        {
            if (binaryForm % 2 == 1)
            {
                ans *= x;
            }
            x *= x;
            binaryForm = binaryForm / 2;
        }
        return ans;

    }
}