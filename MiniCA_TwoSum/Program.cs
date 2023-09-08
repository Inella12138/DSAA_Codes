using MiniCA_TwoSum;

int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = TwoSumSol_Onlogn.TwoSum(nums, target);

Console.WriteLine("Indices of the two numbers: " + result[0] + ", " + result[1]);
