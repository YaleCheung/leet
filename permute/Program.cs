using System;
using System.Collections.Generic;

namespace Permute
{

    class Solution
    {
        public void Permute(int[] nums, IList<IList<int>> permute_lst, int cur_pos, int post_pos, List<int> tmp) {

            Swap(nums, cur_pos, post_pos);
            tmp.Add(nums[cur_pos]);
            if (tmp.Count == nums.Length) {
                permute_lst.Add(tmp.ToArray());
                tmp.RemoveAt(tmp.Count - 1);
                return;
            }
            for(int j = cur_pos + 1; j < nums.Length; ++ j)
                Permute(nums, permute_lst, cur_pos + 1, j, tmp);
            tmp.RemoveAt(tmp.Count - 1);
            Swap(nums, cur_pos, post_pos);

        }
        public void Swap(int[] nums, int i, int j) {
            int tmp = nums[i];
            nums[i] = nums[j];
            nums[j] = tmp;
        }
        public IList<IList<int>> Permute(int[] nums) {
            IList<IList<int>> ret = new List<IList<int>>();
            List<int> tmp = new List<int>();
            for (int i = 0; i < nums.Length; ++ i) {
                Permute(nums, ret, 0, i, tmp);
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
