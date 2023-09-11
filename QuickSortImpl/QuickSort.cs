using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImpl
{
    public static class QuickSort
    {
        public static void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }

        public static void Sort(int[] nums, int left, int right)
        {
            if (left >= right) { return; }

            int pivot = PartSort(nums, left, right);

            Sort(nums, left, pivot - 1);
            Sort(nums, pivot + 1, right);
        }


        public static int PartSort(int[] nums, int left, int right)
        {
            int pivot = right;
            right = pivot - 1;
            int low = left;
            while (true) 
            {
                while (nums[left] <= nums[pivot] && left < pivot)
                {
                    left++;
                }
                while (nums[right] >= nums[pivot] && right > low)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(ref nums[left], ref nums[right]);
                }
                else { break; }
            }
            Swap(ref nums[left], ref nums[pivot]);
            return left;
        }

        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}
