using System;

namespace first_missing_possitive
{
    class Program
    {
        public int FirstMissingPositive(int[] nums) {
            var ret = 1;
            var max = 0;
            if (nums.Length < 1) 
                return ret;
            for(var i = 0; i < nums.Length; ++ i) {
                if (nums[i] > max)
                     max = nums[i];
                if (nums[i] <= 0 || nums[i] > nums.Length || nums[i] == nums[nums[i] - 1])
                    continue;
                else  {
                    var tmp = nums[nums[i] - 1];
                    nums[nums[i] - 1] = nums[i];
                    nums[i] = tmp;
                    -- i;
                }
            }
            // traverse
            for(var i = 0; i < nums.Length; ++ i) {
                ret = i + 1;
                if(nums[i] != ret)  
                    break;
            }
            return ret == max ? ret + 1 : ret;
        }
        public static void Main(string[] args) {
            var nums = new int[]{1};
            var problem = new Program();
            Console.WriteLine(problem.FirstMissingPositive(nums));

        }
    }
}
