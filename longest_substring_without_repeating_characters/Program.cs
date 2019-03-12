using System;

namespace longest_substring_without_repeating_characters
{
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (0 == s.Length)
            return 0;
        int ret = 1;       

        int[] hash = new int[256];
        for(int i = 0; i < 256; ++ i) 
            hash[i] = -1;

        int start = 0;
        for(int i = 0; i < s.Length; ++ i) {
            var c = s[i];
            var idx = hash[c];
            if(idx != -1) {
                if (idx >= start) {
                    ret = (i - start) > ret ? (i - start) : ret;
                    start = idx + 1;
                }
            }
            hash[c] = i;
        }
        return (s.Length - start) > ret ? (s.Length - start) : ret;
    }

    public static void Main(string[] args) {
        var s = new Solution();
        foreach(var str in args) {
            Console.WriteLine("{0} ", s.LengthOfLongestSubstring(str));
        }
    }
}
}
