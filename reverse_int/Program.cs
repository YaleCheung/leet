using System;

namespace reverse_int
{

    public class Solution {
        public int Reverse(int x) {
            int ret = 0;
            bool sign = x > 0 ? true : false;
            x = (sign == true) ? x : -x;

            while(x != 0){
                int d = x % 10;
                x /= 10;
                if (ret > int.MaxValue / 10)
                    return 0;
                ret = ret * 10 + d;
                if (ret < 0)
                    return 0;
            }
            return sign ? ret : -ret;
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("{0} ", new Solution().Reverse(1534236469));
        }
    }
}
