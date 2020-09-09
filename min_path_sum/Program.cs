using System;

namespace min_path_sum
{
    class Program
    {
        public int MinPathSum(int[][] grid) {
            int[] dp = new int[grid[0].Length];
            // init dp
            dp[0] = grid[0][0];
            for(int i = 1; i < dp.Length; ++ i) 
                dp[i] = dp[i - 1] + grid[0][i];
            
            for(int i = 1; i < grid.Length; ++ i) {
                for(int j = 0; j < grid[0].Length; ++ j) {
                    if (j > 0)
                        dp[j] = dp[j] > dp[j - 1] ? dp[j - 1] : dp[j];
                    dp[j] += grid[i][j];
                }
            }
            return dp[dp.Length - 1];
        }
    }
}
