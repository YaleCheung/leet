using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; ++ i) {
            if (dict.ContainsKey(target - nums[i])) 
                return new int [] {i, dict[target - nums[i]]};
            else 
                dict[nums[i]] = i;
        }
        return null;
    }
    public static void Main(string[] args) {
        
    }
}
