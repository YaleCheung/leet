using System;
using System.Collections.Generic;
namespace three_sum
{
    class Program
    {
        public IList<IList<int>> ThreeSum(int[] nums) {
            Array.Sort(nums);    // ascent order;
            IList<IList<int>> ret = new List<IList<int>>();
            for(var i = 0; i < nums.Length - 2;) {
                var j = i + 1;
                var k = nums.Length - 1; 
                while(j < k) {
                    if (nums[j] + nums[j + 1] > -nums[i])
                        break;
                    if (nums[k - 1] + nums[k] < -nums[i])
                        break;

                    if (nums[j] + nums[k] == -nums[i]) {
                    ret.Add(new List<int>(new int[]  {
                        nums[i], 
                        nums[j], 
                        nums[k]
                    }));

                        ++ j;
                        -- k;
                        // filter redundant results 
                        while (j < k && nums[j] == nums[j - 1]) 
                            ++ j;
                        while (j < k && nums[k] == nums[k + 1]) 
                            -- k;

                    } else if (nums[j] + nums[k] < -nums[i]) 
                        ++ j;
                    else 
                        -- k;
                }
                while(i < nums.Length - 2 && nums[i] == nums[i + 1])
                    ++ i;
                ++ i;
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
            var ret = sol.ThreeSum(input);

            foreach(var row in ret) {
                foreach(var elem in row) {
                    Console.Write(elem);
                    Console.Write(" ");
                }
                Console.Write("\n");
            }
            
        }
    }
}
