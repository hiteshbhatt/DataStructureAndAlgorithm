namespace ContainerWithMaximumWater
{

    /*
     * You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container, such that the container contains the most water.

Return the maximum amount of water a container can store.

Notice that you may not slant the container.
    Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case,
    the max area of water (blue section) the container can contain is 49.
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            Console.WriteLine("Maximum water: "+ MaxArea(height));
            Console.ReadLine();
        }

        static int MaxArea(int[] height)
        {
            int maxWater = int.MinValue;
            int left = 0;
            int right = height.Length - 1;
            int currentWater = 0;
            int width = 0;
            int currentHeight = 0;
            while (left < right)
            {

                width = right - left;
                currentHeight = Math.Min(height[left], height[right]);
                currentWater = width * currentHeight;
                maxWater = Math.Max(currentWater, maxWater);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }

            }

            return maxWater;

        }
    }
}
