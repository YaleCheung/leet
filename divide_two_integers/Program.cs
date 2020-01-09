using System;
public class Solution {
    public int Divide(int dividend, int divisor) {
        int ret = 0;
        if (dividend == int.MinValue && (divisor == -1 || divisor == 1))
            return int.MaxValue;
        int sign_dividend = 1;
        int sign_divisor = 1;
        if (dividend == 0) 
            return ret;

        if (dividend > 0)
        {
            sign_dividend = 1;
            dividend = -dividend;
        }
        else
            sign_dividend = -1;
        if (divisor > 0)
        {
            sign_divisor = 1;
            divisor = -divisor;
        }
        else
            sign_divisor = -1;

        int multi_factor = 1;
        while(dividend < 0){
            int tmp = dividend - multi_factor * divisor;
            if ((tmp > 0 && multi_factor > 0) 
             || (multi_factor != 0 && int.MinValue / multi_factor > divisor)
                ) {
                multi_factor /= 2;
            } else if (multi_factor == 0)
                break;
            else {
                ret += multi_factor;
                multi_factor += 1;
                dividend = tmp;
            }
        }
        
        return (sign_divisor == sign_dividend) ? ret : -ret;
    }
    static void Main(string[] args) {
        if(args.Length != 2) {
            Console.WriteLine($"{args.Length}");
            return;
        }
        Console.WriteLine($"{new Solution().Divide(Convert.ToInt32(args[0]), Convert.ToInt32(args[1]))}");
        return;
    }
}

