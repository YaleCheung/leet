using System;

public class Solution {
    public bool isMatch(string s, string p) {
        // dp init;
        bool [,] dp = new bool [s.Length + 1, p.Length + 1];
        for(int i = 0; i < s.Length + 1; ++ i) {
            for(int j = 0; j < p.Length + 1; ++ j) 
                dp[i, j] = true;
        }

        // from bottom 
        for(int i = s.Length; i >= 0; -- i) {
            for(int j = s.Length; j >= 0; -- j) {
                bool try_match = false;
                if (i >= 1 && 
                   (s[i - 1] == p[j - 1] || 
                    p[j - 1] == '.'))
                    try_match = true;
                if (j >= 2 && p[j - 1] == '*')
                    dp[i, j] = dp[i, j - 2] || try_match && dp[i - 1, j];
                else 
                    dp[i, j] = try_match && dp[i - 1, j - 1];
            } 
        }
        return dp[0, 0];
    }
    public static int Main(string[] args) {
        string s = args[0];
        string p = args[1];
        Console.WriteLine("{0}", new Solution().isMatch(s, p)); 
        return 0;
    }
}
