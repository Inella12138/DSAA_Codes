using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA_TwoSum
{
    public static class TwoSumSol_On2
    {
        //brute-force solution
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j }; 
                    }
            //just iterate the array twice to find possible solution, its time efficiency is O(n2)
                }               
            }
            throw new Exception("No solution");
        }
    }
}
