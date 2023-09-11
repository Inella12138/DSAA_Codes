using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortImpl
{
    public static class QuickSort_2
    {
        public static void Sort(int[] nums)
        {
            Sort(nums, 0, nums.Length - 1);
        }

        public static void Sort(int[] nums,int left,int right)
        {
            if (left >= right)  { return; }

            int pivot = PartSort(nums, left, right);

            Sort(nums, left, pivot - 1);
            Sort(nums, pivot + 1, right);
        }
        public static int PartSort(int[] nums, int left, int pivot)
        {
            int index = left;
            int less = left;
            while (index < pivot)
            {
                if (nums[index] <= nums[pivot])
                {                   
                    if (less < index)
                    {
                        Swap(ref nums[less], ref nums[index]);
                    }
                    less++;
                }
                index++;
            }
            Swap(ref nums[less], ref nums[pivot]);
            return less;
        }

        public static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b; 
            b = t;
        }
    }
}
