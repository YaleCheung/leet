using System;

namespace search
{
    class Program
    {
        public int Search(int[] nums, int target) {
            var ret = -1;
            var beg = 0;
            var end = nums.Length - 1;
            while(beg <= end) {
                var mid = (beg + end) / 2;
                if (target > nums[mid])
                {
                    if ((nums[beg] < nums[end])
                    || (nums[mid] > nums[end])
                    || (nums[mid] < nums[end] && target <= nums[end]))
                        beg = mid + 1;
                    else
                        end = mid - 1;
                }
                else if (target < nums[mid])
                {
                    if ((nums[beg] < nums[end])
                    ||  (nums[mid] > nums[end] && target > nums[end]) 
                    ||  (nums[mid] < nums[end]))
                        end = mid - 1;
                    else
                        beg = mid + 1;
                }
                else
                {
                    ret = mid;
                    break;
                }
            }
            return ret;

        }
        static void Main(string[] args)
        {
            var program = new Program();
            int[] nums = {5, 1, 2, 3, 4};
            Console.WriteLine($"{program.Search(nums, 1)} ") ;
        }
    }
}
