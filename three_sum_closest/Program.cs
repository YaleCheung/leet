using System;
using System.Collections.Generic;

namespace three_sum_closest
{
    class Program
    {
        public int ThreeSumClosest(int[] nums, int target) {
            Array.Sort(nums);
            var min_diff = Int32.MaxValue;
            var ret = 0;
            for(var i = 0; i < nums.Length - 2; ++ i) {
                var j = i + 1;
                var k = nums.Length - 1;

                while (j < k) {
                    var sum = nums[j] + nums[k] + nums[i]; 
                    if (sum == target)
                        return sum;
                    else if (sum < target) {
                        ++ j;
                        if (target - sum < min_diff) {
                            min_diff = target - sum;
                            ret = sum;
                        }
                    }
                    else if (sum > target) {
                        -- k;
                        if (sum - target < min_diff) {
                            min_diff = sum - target;
                            ret = sum;
                        }
                    }
                }
            }
            return ret;
        }

        static void Main(string[] args)
        {
            var input = new int[args.Length];

            for(int order = 0; order < args.Length; ++ order) {
                input[order] = Convert.ToInt32(args[order], 10);
            }
            var sol = new Program();
            var ret = sol.ThreeSumClosest(input, 1);

            Console.WriteLine("{0}", ret);
        }
    }
}
