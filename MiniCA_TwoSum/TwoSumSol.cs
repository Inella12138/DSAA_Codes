using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCA_TwoSum
{
    //Given an array of integers and an integer target,
    //return the indices of the two numbers such that they add up to the target
    public static class TwoSumSol
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> index = new Dictionary<int, int>();
            //Create a dictionary that stores the index of each number in nums[]

            for (int i = 0; i < nums.Length; i++)
            {
                int adder = target - nums[i];   //find adder for each number in nums[]              
                if (index.ContainsKey(adder))   //if adder matches with a existed number in dictionary
                {
                    return new int[] { index[adder], i };   
                    //return index of that number and index of current number
                }
                index[nums[i]] = i;             //if not matched, add current mumber to dictionary
            }
            throw new Exception("No solution.");
            //if not matched after iterating through the array, there is no solution
        }
    }
}
