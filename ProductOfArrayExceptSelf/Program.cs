namespace ProductOfArrayExceptSelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProductOfArrayExSelf();
            Console.ReadLine();
        }

        static void ProductOfArrayExSelf()
        {
            int[] nums = [1, 2, 3, 4, 5];

            int[] ans = new int[nums.Length];
            ans[0] = 1;

            //prefix[i]= prefix[i-1] * nums[i-1]
            for (int i = 1; i < nums.Length; i++)
            {
                ans[i] = ans[i-1] * nums[i - 1];
            
            }

            int suffix = 1;
            for (int i = nums.Length - 2; i >= 0; i--) { 
            
                suffix *= nums[i+1];
                ans[i] *= suffix;
            
            
            
            }

            Console.WriteLine(string.Join(',', ans));
;        }
    }


}
