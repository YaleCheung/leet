using System;
using System.Collections.Generic;

namespace find_substring
{
    class Program
    {
        public IList<int> FindSubstring(string s, string[] words) {
            // construct a hash
            var ret = new List<int>();
            var word_num = words.Length;
            if (word_num == 0)
                return ret;
            
            var word_length = words[0].Length;
            if (word_length * word_num > s.Length)
                return ret;
            var hash = new Dictionary<string, int>();
            foreach(var word in words) {
                if (hash.ContainsKey(word)) 
                    hash[word] += 1;
                else hash.Add(word, 1);
            }

            var temp = new Dictionary<string, int>();
            var match_num = 0;
            var start_pos = 0;
            for(int i = 0; i < s.Length - word_length + 1;) {
                if (match_num == 0)
                    start_pos = i;
                var substr = s.Substring(i, word_length);
                if (hash.ContainsKey(substr)) {
                    if (temp.ContainsKey(substr))
                        ++ temp[substr];
                    else 
                        temp.Add(substr, 1);
                    if (temp[substr] > hash[substr]) {
                        temp.Clear();
                        match_num = 0;
                        i = start_pos + 1;
                        continue;
                    }
                    ++ match_num;
                    if (match_num == word_num) {
                        ret.Add(start_pos);
                        temp.Clear();
                        match_num = 0;
                        i = start_pos + 1;
                    } else 
                        i += word_length;
                } else {
                    i = start_pos + 1;
                    temp.Clear();
                    match_num = 0;
                    continue;
                }
            }
            return ret;

        }
        static void Main(string[] args)
        {
            var s = args[0];
            var words = new string[args.Length - 1];
            for(int i = 1; i < args.Length; ++ i) 
                words[i - 1] = args[i];
            var problem = new Program();
            var ret = problem.FindSubstring(s, words);
            foreach(var idx in ret) 
                Console.WriteLine($"{idx} ");
        }
    }
}
