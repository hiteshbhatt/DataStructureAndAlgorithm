namespace ArrayOperations
{
    internal class Program
    {

        static void Display(ArrayList arrayList)
        {
            

                Console.WriteLine("Display element in an array");
                for (int i = 0; i < arrayList.length; i++)
                {
                    Console.Write($"{arrayList.arr[i]} ");

                }

           
        }

        static void Append(ArrayList arrayList,int element) {

            Console.WriteLine("Append element in an array");
            arrayList.arr[arrayList.length] = element;
            arrayList.length++;
        
        }
        static void Insert(ArrayList arrayList, int element, int index) {

            Console.WriteLine($"Insert {element} at i = {index}");
           if(index>0 && index<arrayList.length)
            {
               
                for (int i =arrayList.length; i>index; i--)
                {
                    arrayList.arr[i] = arrayList.arr[i-1];

                }

                arrayList.arr[index] = element;
                arrayList.length++;

            }
           
        
        }
        static void Delete(ArrayList arrayList, int index)
        {
            Console.WriteLine($"Delete element {arrayList.arr[index]}");
            for (int i = index; i < arrayList.length; i++)
            {
                arrayList.arr[i] = arrayList.arr[i + 1];
            }

            arrayList.length--;

        }
        static void Main(string[] args)
        {
            var arrayList = new ArrayList(10,5);
            //insert element in an array
            for(int i = 0; i < arrayList.length; i++)
            {
                Console.WriteLine($"insert element in an array a index a");
                arrayList.arr[i] = int.Parse( Console.ReadLine() );
            }
            Display( arrayList );
            Console.WriteLine();
            Append(arrayList, 60);
            Console.WriteLine();
            Display( arrayList );
            Console.WriteLine();
            Insert(arrayList, 15, 2);
            Console.WriteLine();
            Display(arrayList);
            Console.WriteLine();
            Delete(arrayList, 3 );
            Console.WriteLine();
            Display(arrayList);
            Console.WriteLine();
            for(int i = 0; i < arrayList.size; i++)
            {
                Console.WriteLine(arrayList.arr[i]);
            }


            Console.ReadLine();
            Console.WriteLine("Hello, World!");
        }
    }
}
