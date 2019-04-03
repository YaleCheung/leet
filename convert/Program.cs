using System;

namespace Convert
{
    class Solution
    {
        public string Convert(string s, int numRows) {
            var ret = new string("");
            if (s == null || s.Equals(String.Empty) || 1 == s.Length)
                ret = s;
            else {
                int step = 2 * numRows - 2;
                for(int i = 0, k = 0; i < numRows; ++ i, ++ k) {
                    int j = i;
                    while(j < s.Length) {
                        ret += s[j];
                        var interval = step - 2 * k;
                        if (k != 0 && 
                            interval > 0 && 
                            j + interval < s.Length
                            ) {
                            ret += s[j + interval];
                        }
                        j += step;

                    }
                }
            }
            return ret;
        }
        static void Main(string[] args)
        {
            foreach(var str in args) {
                Console.WriteLine("{0} ", new Solution().Convert(str, 3));
                Console.WriteLine("{0} ", new Solution().Convert(str, 4));
                Console.WriteLine("{0} ", new Solution().Convert(str, 5));
            }
        }
    }
}
