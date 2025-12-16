using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperations
{
    public class ArrayList
    {
        public int size;  // capacity of array
        public int length; // total number of element in an aary
        public int[] arr;
        public ArrayList(int size, int length)
        {

            this.size = size;
            this.length = length;
            arr = new int[size];

        }
    }
}
