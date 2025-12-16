namespace MinAndMaxNumberSingleScan
{
    internal class Program
    {
        /*Find min and max number in a single scan*/
        static void Main(string[] args)
        {
            Console.WriteLine("Min and Max number in a single scan");
            int[] arr = { 5,8,6,9,3,2,10,7,-1,4};
            FindMinAndMaxNumber(arr);
            Console.ReadLine();
        }

        static void FindMinAndMaxNumber(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                else if (arr[i] > max) { 
                 max = arr[i];
                }

            }
            Console.WriteLine($"Min: {min} and Max: {max}");

        }
    }
}
