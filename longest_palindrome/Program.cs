using System;

namespace longest_palindrome
{
    class Solution 
    {
        public string LongestPalindrome(string s) {
            var ret = new string("");
            if(0 == s.Length)
                return "";
            var max = 0;
            for(var i = 0; i < s.Length; ++ i) {
                var cur1 = palindromeLength(s, i, i);
                if (cur1 > max) {
                    ret = s.Substring(i - (cur1 - 1) / 2, cur1);
                    max = cur1;
                }
                if ((i + 1 < s.Length) && 
                    (s[i] == s[i + 1])) {
                    var cur2 = palindromeLength(s, i, i + 1);
                    if (cur2 > max) {
                        ret = s.Substring(i - (cur2 - 1) / 2, cur2);
                        max = cur2;
                    }
                }
            }
            return ret;
        }
        int palindromeLength(string s, int i, int j) {
            var cur = (i == j) ? 1 : 2;
            for(var k = 1; i - k >= 0 && j + k < s.Length; ++ k) {
                if(s[i - k] == s[j + k]) 
                    cur += 2;
                else
                    break;
            }
            return cur;
        }
        
        static void Main(string[] args)
        {
            foreach(var str in args) {
                Console.WriteLine("{0} ", new Solution().LongestPalindrome(str));
            }
        }
    }
}
