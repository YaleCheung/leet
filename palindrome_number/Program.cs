using System;

namespace palindrome_number
{
    class Solution 
    {
		public bool IsPalindrome(int x) {
            if (x < 0)
                return false; 
            bool ret = true;
            string str = x.ToString();
			for(int i = 0, j = str.Length - 1; i < j; ++ i, -- j) {
                if (str[i] != str[j]) {
                    ret = false;
                    break;
                }
			}
            return ret;
		}
        static void Main(string[] args)
        {
            foreach(var arg in args) {
                Console.WriteLine("{0} ", new Solution().IsPalindrome(Convert.ToInt32(arg)));
			}
        }
    }
}
