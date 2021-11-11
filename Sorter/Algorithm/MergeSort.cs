using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.Algorithm
{
    public class MergeSort
    {
        public int[] MergeSortBegin(int[] arr)
        {
            SortMerge(arr, 0, arr.Length - 1);
            return arr;
        }
        public void MainMerge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[arr.Length];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (arr[left] <= arr[mid])
                    temp[pos++] = arr[left++];
                else
                    temp[pos++] = arr[mid++];
            }
            while (left <= eol)
                temp[pos++] = arr[left++];
            while (mid <= right)
                temp[pos++] = arr[mid++];
            for (i = 0; i < num; i++)
            {
                arr[right] = temp[right];
                right--;
            }
        }
        public void SortMerge(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(numbers, left, mid);
                SortMerge(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
