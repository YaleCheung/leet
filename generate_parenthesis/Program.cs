using System;
using System.Collections.Generic;

namespace generateParenthesis
{
    class Program
    {
        private void Helper(string cur, int left_num, int right_num, int n, IList<string> ret)
        {
            if (left_num + right_num == 2 * n)
            {
                ret.Add(cur);
                return;
            }
            if (left_num < n)
            {
                Helper(cur + '(', left_num + 1, right_num, n, ret);
                if (left_num > right_num)
                {
                    Helper(cur + ')', left_num, right_num + 1, n, ret);
                }
            }
            else
            {
                Helper(cur + ')', left_num, right_num + 1, n, ret);
            }
        }
        public IList<string> GenerateParenthesis(int n)
        {
            var ret = new List<string>();
            Helper("", 0, 0, n, ret);
            return ret;
        }
        static void Main(string[] args)
        {
            var program = new Program();
            var ret = program.GenerateParenthesis(Convert.ToInt32(args[0]));
            foreach (var str in ret)
            {
                Console.WriteLine("{0} ", str);
            }

        }
    }
}
