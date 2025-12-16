namespace ArrayReverseShiftRotate
{
    /**
     * https://www.youtube.com/watch?v=wvcQg43_V8U
     * https://www.youtube.com/watch?v=0OTPqrEd74g
     */
    internal class Program
    {
        static  void Reverse(int[] a)
        {
            for (int i=0,j=a.Length-1;i<j;i++,j--)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }

            
        }

        static void LeftShift(int[] a)
        {
            for(int i = 0; i < a.Length-1; i++)
            {
                a[i] = a[i+1];
            }
            a[a.Length - 1] = 0;
        }

        static void RightShift(int[] a)
        {
            for (int i = a.Length-1; i >0; i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = 0;
        }

        static void RotateRight(int[] a)
        {
            int x = a[a.Length - 1];
            for (int i = a.Length - 1; i > 0; i--)
            {
                a[i] = a[i - 1];
            }
            a[0] = x;
        }
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 30, 40, 50, 60 };
            RotateRight(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


            //Left Rotate array by 3 places
            
            RotateElementLeftByKPlaces rotateElementLeftByKPlaces = new RotateElementLeftByKPlaces();
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine($"Left Rotate array {{ 1, 2, 3, 4, 5, 6, 7 }} by k places");
            rotateElementLeftByKPlaces.LeftRotateElementByKPlacesByBruteForce(arr, 3);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
            Console.ReadLine();
       }
    }
}
