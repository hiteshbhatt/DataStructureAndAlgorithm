using System.Diagnostics.CodeAnalysis;

namespace MissingNumberArray
{
    internal class Program
    {//https://www.youtube.com/watch?v=bYWLJb3vCWY
        //https://www.youtube.com/watch?v=bYWLJb3vCWY&list=PLgUwDviBIf0rENwdL0nEH0uGom9no0nyB&index=3
        static void Main(string[] args)
        {
            Console.WriteLine("Missing element in a sequence of natural number");
            int[] arr = { 1, 2, 3, 4 ,5,6,8,9,10,11,12};
            FindMissingElementInASequenceOfNaturalNumber(arr);
            Console.WriteLine("Missing element in a sequence of natural number using xor");
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12 };
            FindMissingElementInASequenceOfNaturalNumberUsingXOR(arr1);
            Console.WriteLine($"FindSingleMissingNumberNotASequenceOfNNaturalNumber");
            int[] arr2 = { 6, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17 };
            FindSingleMissingNumberNotASequenceOfNNaturalNumber(arr2);
            Console.WriteLine($"FindMultipleMissingElementInASortedArray");
            int[] arr3 = { 6, 7, 8, 9, 11, 12, 15, 16, 17, 18, 19 };
            FindMultipleMissingElementInASortedArray(arr3);
            
            Console.ReadLine();
            


        }

        static void FindMissingElementInASequenceOfNaturalNumberUsingXOR(int[] arr)
        {
            int xor1 = 0;
            int xor2 = 0;
            for (int i = 0; i < arr.Length-1; i++) {
                xor1 = xor1^ arr[i];
                xor2 = xor2 ^ (i + 1);
            }
            xor2 = xor2 ^ arr.Length;
            int missing = xor1 ^ xor2;
            Console.WriteLine($"Missing number {missing}");
        }

        /// <summary>
        /// Finds and prints the missing element in a sequence of natural numbers starting from 1.
        /// Assumes only one number is missing.
        /// </summary>

        static void FindMissingElementInASequenceOfNaturalNumber(int[] arr)
        {
            int missing = 0;
            int sum = 0;
            int n = arr.Length+1;
            for (int i = 0; i < arr.Length; i++) { 
             sum = sum + arr[i];
            }
            int sumOfNaturalNumber = (n * (n + 1)) / 2;


            missing = sumOfNaturalNumber - sum;
            Console.WriteLine($"Missing number is {missing}");

        }
        /// <summary>
        /// Finds and prints the missing number in a sorted array of consecutive numbers
        /// that does not necessarily start from 1.
        /// Assumes only one number is missing.
        /// </summary>
        static void FindSingleMissingNumberNotASequenceOfNNaturalNumber(int[] arr)
        {
            int l = arr[0];
            int diff = l - 0;

            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] - i != diff) {
                    Console.WriteLine($"Missing number {i + diff}");
                    break;
                }
            }
        }

        static void FindMultipleMissingElementInASortedArray(int[] arr) {
            int l = arr[0];
            int diff = l - 0;
            int h = arr[arr.Length-1];
            int n = arr.Length;
            for (int i = 0; i < n; i++) {
                if (arr[i] - i != diff)
                {
                    while (diff < arr[i] - i)
                    {
                        Console.WriteLine($"missing number {diff + i}");
                        diff++; ;
                    }
                }
            }
        
        }
    }
}
