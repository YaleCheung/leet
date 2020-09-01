using System;

namespace can_jump
{
public class Solution {

    public bool CanJump(int[] nums) {
        bool[] hash = new bool[nums.Length];
        for(var i = 1; i < nums.Length; ++ i)
            hash[i] = false;
        hash[0] = true;
        for(int i = 0; i < nums.Length; ++ i) {
            for(int j = 1; j <= nums[i]; ++ j) {
                if (i + j <= nums.Length - 1)
                    hash[i + j] = hash[i + j] || hash[i];
            }
        }
        return hash[hash.Length - 1];
    }
    static void Main(string[] args) {
        var sol = new Solution();
        bool ret = sol.CanJump(new int[]{2,3,1,1,4});
        Console.WriteLine(ret);
    }
}
}
