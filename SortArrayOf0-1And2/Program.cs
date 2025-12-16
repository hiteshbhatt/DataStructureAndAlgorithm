namespace SortArrayOf0_1And2
{
    internal class Program
    {
        //Dutch National Flag problem
        /*
         Given an array arr[] containing only 0s, 1s, and 2s. Sort the array in ascending order.

You need to solve this problem without utilizing the built-in sort function.

Examples:

Input: arr[] = [0, 1, 2, 0, 1, 2]
Output: [0, 0, 1, 1, 2, 2]
Explanation: 0s 1s and 2s are segregated into ascending order.
Input: arr[] = [0, 1, 1, 0, 1, 2, 1, 2, 0, 0, 0, 1]
Output: [0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2]
Explanation: 0s 1s and 2s are segregated into ascending order.         
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Dutch National Flag problem");
            int[] arr = { 0, 1, 2, 0, 1, 2 };
            Console.WriteLine($"array Before sort:{String.Join(",", arr)}");
            Sort012(arr);
            Console.WriteLine($"array after sort:{String.Join(",",arr)}");
            Console.Read();
        }

        static void Swap(int[] arr, int i,int j){
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
            }
        static void Sort012(int[] a)
        {
            int low = 0,mid=0,high = a.Length-1 ;
            while (mid <= high)
            {
                if (a[mid] == 0)
                {
                    Swap(a, low,mid);
                    low++;
                    mid++;
                }
                else if (a[mid] == 1)
                {
                    mid++;
                }
                else
                {
                    Swap(a,mid,high);
                    high--;
                }
            }

        }
    }
}
