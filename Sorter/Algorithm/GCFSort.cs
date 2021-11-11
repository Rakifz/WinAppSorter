using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Algorithm
{
    public class GCFSort
    {
        public int[] GCFSortBegin(int[] arr,int comparator)
        {
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (GCD(arr[i], comparator) > GCD(arr[i + 1], comparator))
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                    else
                    {

                        if (GCD(arr[i], comparator) == GCD(arr[i + 1], comparator))
                        {
                            if (arr[i] > arr[i + 1])
                            {
                                temp = arr[i + 1];
                                arr[i + 1] = arr[i];
                                arr[i] = temp;
                            }
                        }
                    }
                }
            }
            return arr;
        }

        private int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a | b;
        }
    }
}
