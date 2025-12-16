using System.Xml.Linq;

namespace Searching
{
    internal class Program
    {

        static int LinearSearch(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    return i;

                }
                

            }
            return -1;
        }

        static int Transposition(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    // swap
                    int temp = arr[i-1];
                    arr[i-1] = arr[i]; arr[i] = temp;
                    return i;

                }


            }
            return -1;
        }

        static int MoveToHead(int[] arr, int element)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == element)
                {
                    // swap
                    int temp = arr[0];
                    arr[0] = arr[i]; arr[i] = temp;
                    return i;

                }


            }
            return -1;
        }

        static int BinarySearch(int[] arr, int l, int h, int element)
        {
            while (l <= h)
            {
                int mid =(l + h) / 2;
                if (element == arr[mid])
                {
                    return mid;
                }
                if(element< arr[mid])
                {
                    h = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
                int[] arr = { 10, 14, 2, 8, 19, 16 };
                if(LinearSearch(arr, 8) > 0)
                {
                    Console.WriteLine("Found");
                }
                else
                {
                    Console.WriteLine("Not found");
                }

            Console.WriteLine($"Binary Search");
            if (BinarySearch(arr, 0, arr.Length-1, 19) > 0)
            {
                Console.WriteLine("Found element using binary search");
            }
            else
            {
                Console.WriteLine("Not found element using binary search");
            }
            Console.Read();

            Console.WriteLine("Hello, World!");
        }
    }
}
