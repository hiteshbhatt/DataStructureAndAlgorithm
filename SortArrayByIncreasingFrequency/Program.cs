using System.Collections.Generic;

namespace SortArrayByIncreasingFrequency
{
    internal class Program
    {
        /*
         * Given an array of integers nums, sort the array in increasing order based on the frequency of the values. 
         * If multiple values have the same frequency, sort them in decreasing order.
         * Input: nums = [1,1,2,2,2,3]
           Output: [3,1,1,2,2,2]
           Explanation: '3' has a frequency of 1, '1' has a frequency of 2, and '2' has a frequency of 3.
        https://www.geeksforgeeks.org/dsa/sort-elements-by-frequency/#using-hashing-and-sorting-on-log-n-time-and-on-space
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 1, 2, 2, 2, 3 };

            Console.WriteLine($"Frequency sort  {String.Join(",", FrequencySort(arr))}");
            Console.ReadLine();
        }

        static int[] FrequencySort(int[] nums)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {

                if (frequency.ContainsKey(nums[i]))
                {

                    frequency[nums[i]] = frequency[nums[i]] + 1;
                }
                else
                {
                    frequency.Add(nums[i], 1);
                }
            }

            List<KeyValuePair< int,int>> sortedList = new List<KeyValuePair<int, int>>();

            foreach (KeyValuePair<int, int> pair in frequency)
            {
                sortedList.Add(pair);
            }

            sortedList.Sort((a, b) => {
                if (a.Value != b.Value)
                {
                    return a.Value.CompareTo(b.Value);
                }
                else
                {
                    return b.Key.CompareTo(a.Key);
                }
            });
            List<int> result = new List<int>();
        foreach(var sortedPair in sortedList)
            {
                for (int i = 0; i < sortedPair.Value; i++)
                {
                    result.Add(sortedPair.Key);
                }
            }

            return result.ToArray();

        }
    }
}
