using System;

namespace trapping_rain_water
{
    class Solution
    {
        public int Trap(int[] height) {
            int ret = 0;
            int diff = 0;
            int cur_max = 0;
            // pass from left
            for(int i = 0; i < height.Length; ++ i) {
                if (height[i] >= cur_max) {
                    ret += diff; 
                    cur_max = height[i];
                    diff = 0;
                } else 
                    diff += cur_max - height[i];
            }
            
            // reset variables
            cur_max = 0;
            diff = 0;
            // pass from right
            for(int i = height.Length - 1; i >= 0; -- i) {
                if (height[i] > cur_max) {
                    ret += diff; 
                    cur_max = height[i];
                    diff = 0;
                } else 
                    diff += cur_max - height[i];
            }
            return ret;
        }
        static void Main(string[] args)
        {
            int arg_num = args.Length;
            int[] height = new int[arg_num];
            for(int i = 0; i < args.Length; ++ i){
                height[i] = Convert.ToInt32(args[i]);
            }
            Solution sol = new Solution();
            Console.WriteLine($"{sol.Trap(height)}");
            
        }
    }
}
