namespace FindMissingAndRepeatingNumberGeek
{
    internal class Program
    {
        //https://www.youtube.com/watch?v=ncvJHz_gffI
        //You are given an array arr[] containing positive integers. The elements in the array
        //arr[] range from  1 to n (where n is the size of the array),
        //and some numbers may be repeated or absent. Your have to count the frequency of
        //all numbers in the range 1 to n and return an array of size n such that result[i]
        //represents the frequency of the number i (1-based indexing).
        // Input: arr[] = [2, 3, 2, 3, 5]
        //Output: [0, 2, 2, 0, 1]
        //Explanation: We have: 1 occurring 0 times, 2 occurring 2 times,
        //3 occurring 2 times, 4 occurring 0 times, and 5 occurring 1 time.
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 1, 2, 7, 6 };
            FindMissingAndRepeatingNumber(arr, arr.Length);
            Console.ReadLine();

        }

        static void FindMissingAndRepeatingNumber(int[] arr, int n)
        {
            for(int i= 0; i < n; i++)
            {
                arr[i]--;
            }
            for(int i = 0; i < n; i++)
            {
                arr[arr[i] % n] += n;
            }

            for(int i = 0; i < n; i++)
            {
                if (arr[i] / n > 1)
                {
                    Console.WriteLine($"Number {i + 1} is repeating {arr[i] / n}");
                }
                else if (arr[i] / n == 0)
                {
                    Console.WriteLine($"{i + 1} number is missing");
                }
            }

        }
    }
}
