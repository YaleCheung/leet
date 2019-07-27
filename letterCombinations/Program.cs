using System;
using System.Collections.Generic;

namespace letterCombinations
{
    public class Program
    {
        public void LetterCombinations(string[] hash, string curStr, int pos, IList<string> ret, string digits) {
            if (pos == digits.Length) {
                ret.Add(curStr);
                return;
            }
            for(int i = 0; i < hash[digits[pos] - '2'].Length; ++ i) 
                LetterCombinations(hash, curStr + hash[digits[pos] - '2'][i], pos + 1, ret, digits);
        }
        public IList<string> LetterCombinations(string digits) {
            // hash
            string[] hash = {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
            var ret = new List<string>();
            if (digits.Length == 0)
                return ret;
            var str = new string("");
            LetterCombinations(hash, str, 0, ret, digits);
            return ret;
        }
        static void Main(string[] args)
        {
            var program = new Program();
            var ret = program.LetterCombinations(args[0]);
            foreach(var ele in ret) {
                Console.WriteLine("{0} ", ele);
            }
        }
    }
}
