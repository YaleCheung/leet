using System;

namespace is_match
{
    class Program
    {
        bool isMatch(string s, string p) {
            // dp init;
            bool [,] dp = new bool [s.Length + 1, p.Length + 1];
            for(int i = 1; i < s.Length + 1; ++ i)
                dp[i, 0] = false;
            for(int j = 1; j < p.Length + 1; ++ j)
                dp[0, j] = false;
            
            dp[0, 0] = true;
            for(int i = 1; i <= p.Length; ++ i) {    // case a && c*b*a*
                if (p[i - 1] == '*')
                    dp[0, i] = dp[0, i - 2];
            } 

            // from bottom 
            for(int i = 1; i <= s.Length; ++ i) {
                for(int j = 1; j <= p.Length; ++ j) {
                    if (p[j - 1] == '.') 
                        dp[i, j] = dp[i - 1, j - 1];
                    else if (p[j - 1] == '*') {
                        dp[i, j] = ((s[i - 1] == p[j - 2] || p[j - 2] == '.') && dp[i - 1, j]) || 
                        dp[i, j - 2];
                    } else 
                        dp[i, j] = (s[i - 1] == p[j - 1]) && dp[i - 1, j - 1];
                } 
            }
            return dp[s.Length, p.Length];
        }

        public static int Main(string[] args) {
            string s = "";
            string p = ".*";
            Console.WriteLine("{0}", new Program().isMatch(s, p)); 
            return 0; 
        }
    }
}
