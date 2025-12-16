using System.Collections.Generic;

namespace DupilcateInAnArray
{
    internal class Program
    {
        //https://www.youtube.com/watch?v=37E9ckMDdTk
        //https://www.youtube.com/watch?v=ncvJHz_gffI
        static void Main(string[] args)
        {
            Console.WriteLine("Finding Duplicates in an sorted array");
            int[] arr = { 3,6,8,8,10,12,15,15,15,20};
            DuplicateInSortedArray(arr);

            Console.WriteLine("Counting duplicate in Sorted array");
            CountingDuplicateInSortedArray(arr);

            Console.WriteLine("Counting duplicate in Sorted array using hasing");
            CountingDuplicateInSortedArrayUsingHashing(arr);
            Console.WriteLine("Counting duplicate in UnSorted array using hasing");
            int[] arr1 = { 8, 3, 6, 4, 6, 5, 6, 8, 2, 7 };
            CountingDuplicateInSortedOrUnSortedArrayUsingHashingDictionary(arr1);

            Console.WriteLine("Counting duplicate in UnSorted array using bruteforce");
            FrequecyOfElementInUnSortedArrayUsingBruteforceApproach(arr1);
            Console.Read();
         }

        //Finding duplicate in a sorted array
        static void DuplicateInSortedArray(int[] arr)
        {
            int lastDuplicate = 0;
            for (int i = 0; i < arr.Length-1; i++) {

                if (arr[i] == arr[i + 1] && arr[i]!=lastDuplicate)
                {
                    Console.WriteLine(arr[i]+" ");
                    lastDuplicate = arr[i];
                }
            
            }

        }

        //Couting duplicate in an sorted array
        static void CountingDuplicateInSortedArray(int[] arr)
        {
            int j = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                
                if (arr[i] == arr[i + 1])
                {
                    j=i+1;
                    while (arr[i] == arr[j]) j++;
                    Console.WriteLine($"{arr[i]} repeated {i-j} times ");
                    i = j - 1;
                }
                

            }
        }

        static void CountingDuplicateInSortedArrayUsingHashing(int[] arr)
        {
            int[] hashArray = new int[arr[arr.Length-1]];
            for (int i = 0;i < arr.Length - 1; i++)
            {
                hashArray[arr[i]]++;
            }

            for(int i = 1; i < hashArray.Length; i++)
            {
                if (hashArray[i]>1)
                Console.WriteLine($"{i} repeated {hashArray[i]} times");
            }
        }

        static void CountingDuplicateInSortedOrUnSortedArrayUsingHashingDictionary(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (frequency.ContainsKey(arr[i]))
                {
                    frequency[arr[i]] = frequency[arr[i]]+ 1;
                }
                else
                {
                    frequency.Add(arr[i], 1);
                }
            }

            foreach(KeyValuePair<int,int> entry in frequency)
            {
                if (entry.Value > 1)
                {
                    Console.WriteLine(entry.Key + " repeates " + entry.Value + " times");
                }
            }

           
        }

        static void FrequecyOfElementInUnSortedArrayUsingBruteforceApproach(int[] arr)
        {
            int count = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == -1) continue;
                count = 1;
                for(int j=i+1; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1;
                    }
                }
                if(count>1)
                Console.WriteLine(arr[i] + " repeates " + count + " times");
            }
        }
    }
}
