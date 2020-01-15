using System;

namespace next_permutation
{
    class Program
    {
        public void NextPermutation(int[] nums) {
            var end = nums.Length - 1;
            var start_reverse = -1;
            for(var i = end; i > 0; -- i) {
                if (nums[i] > nums[i - 1]) {
                    start_reverse = i;
                    break;
                }
            }
            if (-1 == start_reverse) { // totally reverse
                Array.Sort(nums);
                return;
            }
             
            // find the minimum number bigger than i - 1
            var minor_diff = int.MaxValue;
            var minor_pos = 0;
            for(var i = end; i >= start_reverse; -- i) {
                var diff = nums[i] - nums[start_reverse - 1];
                if (diff > 0 && diff < minor_diff) {
                    minor_diff = diff;
                    minor_pos = i;
                }
            }
            // swap and re-sort later part;
            var tmp = nums[start_reverse - 1];
            nums[start_reverse - 1] = nums[minor_pos];
            nums[minor_pos] = tmp;
            Array.Sort(nums, start_reverse, nums.Length - start_reverse);
        }

        static void Main(string[] args)
        {
            var nums = new int[args.Length];
            for(var i = 0; i < args.Length; ++ i) 
                nums[i] = Convert.ToInt32(args[i]);
            var sol = new Program();
            sol.NextPermutation(nums);
            foreach(var ele in nums)
                Console.WriteLine($"{ele}"); 
        }
    }
}
