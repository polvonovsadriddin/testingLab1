using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class MyCalc
    { public int FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            { if (arr[i] > max) max = arr[i]; }
             return max;
         }
        public int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            { if (arr[i] <min) min = arr[i]; }
            return min;     
        }
    }
}
