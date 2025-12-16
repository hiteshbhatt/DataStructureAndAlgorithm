using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseShiftRotate
{
    public class RotateElementLeftByKPlaces
    {

        /**
         * k = 3
         * [1,2,3,4,5,6,7] a.length = 7
         * tmp = {1,2,3}
         * a = [4,5,6,7,]
         * [4,5,6,7,1,2,3]
         */
        public void LeftRotateElementByKPlacesByBruteForce(int[] a , int k)
        {
            int[] temp  = new int [k];
            Array.Copy(a, temp, k);
            for (int i = k ; i < a.Length; i++)
            {
                a[i-k] = a[i];
            }
            for(int i = a.Length-k;i<a.Length;i++)
            {
                a[i] = temp[i-(a.Length-k)];   //4  -> 0    a.lenght = 7  i = 4 k =3
            }


        }
    }
}
