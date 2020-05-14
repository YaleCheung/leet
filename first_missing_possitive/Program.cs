using System;

namespace first_missing_possitive
{
    class Program
    {
        public int FirstMissingPositive(int[] nums) {
            var ret = 1;
            if (nums.Length == 0) 
                return ret;
            for(var i = 0; i < nums.Length; ++ i) {
                if (nums[i] > 0 
                 && nums[i] <= nums.Length
                 && nums[nums[i] - 1] != nums[i]) {
                    std::swap(nums[nums[i] - 1], nums[i]);
                    -- i;
                }
            }
            // traverse
            for
        }
    }
}
