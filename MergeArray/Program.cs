namespace MergeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] arr1 = { 1, 2, 3, 4 };
            int[] arr2 = { 17, 20, 30, 37 };

            //merge sort
            int[] arr3 = MergeSortedArray(arr1, arr2);
            Console.WriteLine("Merge two Sorted array");
            Console.WriteLine($"arr1: [{string.Join(',', arr1)}]");
            Console.WriteLine($"arr2: [{string.Join(',', arr2)}]");

            Console.WriteLine(string.Join(',', arr3));

            Console.WriteLine("Union of two arrays");
            int[] arr4 = { 4, 5, 6, 7 };
            int[] arr5 = { 1,4,7,10,16 };
            int[] arr6 = UnionSortedArray(arr4, arr5);
            Console.WriteLine("Union two Sorted array");
            Console.WriteLine($"arr4: [{string.Join(',', arr4)}]");
            Console.WriteLine($"arr5: [{string.Join(',', arr5)}]");
            Console.WriteLine(string.Join(',', arr6));

            Console.WriteLine("Intersection of two arrays");
            int[] arr7 = { 4, 5, 6, 7 };
            int[] arr8 = { 1, 4, 7, 10, 16 };
            int[] arr9 = IntersectionSortedArray(arr7, arr8);
            Console.WriteLine("Union two Sorted array");
            Console.WriteLine($"arr4: [{string.Join(',', arr7)}]");
            Console.WriteLine($"arr5: [{string.Join(',', arr8)}]");
            Console.WriteLine(string.Join(',', arr9));

            Console.WriteLine("Difference of two arrays");
            int[] arr10 = { 4, 5, 6, 7 };
            int[] arr11 = { 1, 4, 7, 10, 16 };
            int[] arr12 = Difference(arr7, arr8);
            Console.WriteLine("Difference two Sorted array");
            Console.WriteLine($"arr10: [{string.Join(',', arr10)}]");
            Console.WriteLine($"arr11: [{string.Join(',', arr11)}]");
            Console.WriteLine(string.Join(',', arr12));

            Console.ReadLine();
        }

        static int[] UnionSortedArray(int[] arr1, int[] arr2)
        {
            List<int> arr3 = new List<int>();
            int i, j, k;
            i = j = k = 0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3.Add(arr1[i++]);
                }
                else if (arr2[j] < arr1[i])
                {
                    arr3.Add(arr2[j++]);
                }
                else if(arr1[i] == arr2[j])
                {
                    arr3.Add(arr1[i++]);
                    j++;
                }
                
            }
            for (; i < arr1.Length; i++)
            {
                arr3.Add( arr1[i]);
            }
            for (; j < arr2.Length; j++)
            {
                arr3.Add(arr2[j]);
            }
            return arr3.ToArray();
        }

        static int[] Difference(int[] arr1, int[] arr2) { 
        
         List<int> arr3 = new List<int>();
            int i, j, k;
            i=j=k = 0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    arr3.Add(arr1[i]);
                    i++;
                }
                else if((arr2[j]< arr1[i]))
                {
                    j++;
                }
                else
                {
                    i++;
                    j++;
                }
            }
            return arr3.ToArray();
        }

        static int[] IntersectionSortedArray(int[] arr1, int[] arr2) {
            List<int> arr3 = new List<int> ();
            int i, j, k;
            i = j = k = 0;
            while(i<arr1.Length && j < arr2.Length)
            {
                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr2[j] < arr1[i])
                {
                    j++;
                }
                else if((arr1[i] == arr2[j]))
                {
                    arr3.Add(arr1[i++]);
                    j++;
                }
            }


            return arr3.ToArray();
        
        }

        static int[] MergeSortedArray(int[] arr1,int[] arr2)
        {
            int[] arr3 = new int[arr1.Length+ arr2.Length];
            int i, j, k;
            i = j = k = 0;
            while (i < arr1.Length && j < arr2.Length) {

                if (arr1[i] < arr2[j])
                {
                    arr3[k++] = arr1[i++];
                }
                else
                {
                    arr3[k++] = arr2[j++];
                }
            }
            for (; i < arr1.Length; i++) {
                arr3[k++]= arr1[i];
            }
            for (; j < arr2.Length; j++) {
                arr3[k++] = arr2[j];
            }

            return arr3;
        }
    }
}
