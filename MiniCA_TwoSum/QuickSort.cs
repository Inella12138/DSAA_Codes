using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA_TwoSum
{
    public static class QuickSort
    {
        // restrict our sorting only within the range of left and right
        public static void Sort(int[] arr, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int pivot = Partition(arr, left, right);

            Sort(arr, left, pivot - 1);
            Sort(arr, pivot + 1, right);
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int low = left;
            int pivot = right;
            right = pivot - 1;

            while (true)
            {
                while (left < pivot && arr[left] <= arr[pivot])
                {
                    // keep moving to the right of the array
                    left++;
                }

                while (right > low && arr[right] > arr[pivot])
                {
                    // keep moving to the left of the array
                    right--;
                }

                if (left < right)
                {
                    // swap these two elements in the array
                    Swap(ref arr[left], ref arr[right]);
                }
                else
                {
                    break;
                }
            }

            // slot the pivot-element to the correct position -
            // those on its left will be smaller than it,
            // those on its right will be bigger than it.
            Swap(ref arr[left], ref arr[pivot]);

            // returning the new Pivot position (zero-based index)
            return left;
        }

        // in-place swapping of two values in our array
        private static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }

}
