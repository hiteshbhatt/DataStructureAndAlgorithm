namespace PairOfSumSortedorUnSortedArray
{
    internal class Program
    {
       // https://www.youtube.com/watch?v=tp8JIuCXBaU&t=4s
        //https://www.youtube.com/watch?v=UXDSeD9mN-k
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 12, 14 };
            Console.WriteLine($" Given array [{String.Join(",",arr)}] and k = {10}");
            FindPairWithSumK(10, arr);
            Console.Read();

        }

        static void FindPairWithSumK(int k, int[] arr)
        {
            int i = 0,j = arr.Length - 1;
            while (i < j) {
                if (arr[i] + arr[j] == k)
                {
                    Console.Write($"({arr[i]},{arr[j]}) ");
                    i++;
                    j--;
                }
                else if (arr[i] + arr[j] > k)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            
            }

        }
    }
}
