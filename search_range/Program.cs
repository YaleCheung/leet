using System;

namespace search_range
{
    class Program
    {
        public int find_left(int[] nums, int target) {
            var ret = -1;
            if (nums.Length == 0)
                return ret;
            var beg = 0; 
            var end = nums.Length - 1; 
            while(beg < end) {
                int mid = beg + (end - beg) / 2; 
                if (nums[mid] >= target) 
                    end = mid;
                else 
                    beg = mid + 1;
            }
            if (nums[beg] == target)
                ret = beg;
            return ret;
        }
        public int find_right(int[] nums, int target, int left) {
            var ret = -1;
            if (nums.Length == 0 || left == -1)
                return ret;
            var beg = left; 
            var end = nums.Length - 1; 
            while(beg < end) {
                int mid = beg + (end - beg) / 2; 
                if (nums[mid] > target) 
                    end = mid;
                else 
                    beg = mid + 1;
            }
            if (nums[end] == target)
                ret = end;
            else if (nums[beg - 1] == target)
                ret = beg - 1;
            return ret;
        }

    
        public int[] SearchRange(int[] nums, int target) {
            var l = find_left(nums, target);
            var r = find_right(nums, target, l);
            return new int[]{l, r};
        }
        static int Main(string[] args)
        {
            var sol = new Program();
            var ret = sol.SearchRange(new int[] { 8, 8, 8, 8, 8 }, 8);
            Console.WriteLine($"left is {ret[0]}, right is {ret[1]}"); 
            return 0;
        }        
    }
}
