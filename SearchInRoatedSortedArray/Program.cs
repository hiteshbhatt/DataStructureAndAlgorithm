namespace SearchInRoatedSortedArray
{
    /*
     * 
     * There is an integer array nums sorted in ascending order (with distinct values).

Prior to being passed to your function, nums is possibly left rotated at an unknown index k (1 <= k < nums.length) such that the resulting array is [nums[k], nums[k+1], ..., nums[n-1], nums[0], nums[1], ..., nums[k-1]] (0-indexed). For example, [0,1,2,4,5,6,7] might be left rotated by 3 indices and become [4,5,6,7,0,1,2].

Given the array nums after the possible rotation and an integer target, return the index of target if it is in nums, or -1 if it is not in nums.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [4,5,6,7,0,1,2], target = 0
Output: 4
     * 
     * 
     * 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [4, 5, 6, 7, 0, 1, 2]; int target = 0;
            Console.WriteLine(Search(nums,target));
            Console.Read();
        }
        static int Search(int[] nums, int target)
        {
            int st = 0;
            int mid = 0;
            int end = nums.Length - 1;
            while (st <= end)
            {
                mid = st + (end - st) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[st] <= nums[mid])
                {  //left sorted
                    if (nums[st] <= target && target <= nums[mid])
                    { //binary search target is in left
                        end = mid - 1;
                    }
                    else
                    {
                        st = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] <= target && target <= nums[end])
                    {
                        st = mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }

                }
            }
            return -1;
        }
    }
}
