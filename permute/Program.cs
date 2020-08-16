using System;
using System.Collections.Generic;

namespace Permute
{

    class Solution
    {
        public void Permute(int[] nums, IList<IList<int>> permute_lst, int cur_pos, List<int> tmp) {
            for(int j = cur_pos; j < nums.Length; ++ j) {
                Swap(nums, cur_pos, j);
                tmp.Add(nums[j]);
                if (tmp.Count == nums.Length) {
                    permute_lst.Add(tmp);
                    return;
                }
                Permute(nums, permute_lst, j + 1, new List<int>(tmp.ToArray()));
                Swap(nums, cur_pos, j);
            }
        }
        public void Swap(int[] nums, int i, int j) {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
        public IList<IList<int>> Permute(int[] nums) {
            IList<IList<int>> ret = new List<IList<int>>();
            for (int i = 0; i < nums.Length; ++ i) {
                Permute(nums, ret, 0, new List<int>());
            }
            return ret;
        }

        static void Main(string[] args)
        {
            Solution sol = new Solution();
            var ret = sol.Permute(new int[]{1, 2, 3});
            return;
        }
    }
}
