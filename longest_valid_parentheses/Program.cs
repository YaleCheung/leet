using System;

namespace longest_valid_parentheses
{
    class Program
    {
        // pos as center
        public int LongestValidParentheses(string s) {
            // left
            var max = 0;
            for (var i = 0; i < s.Length; ++i)
            {
                var left = 0;
                var right = 0;
                var length = 0;
                for (var j = i; j < s.Length; ++j)
                {
                    if (s[j] == '(')
                        ++left;
                    else
                        ++right;
                    if (right > left)
                        break;
                    else if (left == right)
                    {
                        ++length;
                        if (length > max)
                            max = length;
                    }
                    else
                        ++length;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
