using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA_TwoSum
{
    public static class TwoSumSol_Onlogn
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            QuickSort.Sort(nums, 0, nums.Length - 1);
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] == target)
                {
                    return new int[] {left, right};
                }
                else if (nums[left] + nums[right] < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            throw new Exception("No solution");
        }
    }
}
