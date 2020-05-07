using System;
using System.Collections.Generic;

namespace combination_sum_2
{
public class Solution {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
            var ret = new List<IList<int>>();
            Array.Sort(candidates);
            CombinationSum2(candidates, target, ret, new List<int>(), 0);
            return ret;

        }
        public void CombinationSum2(int[] candidates, int left, List<IList<int>> ret, List<int> tmp, int index) {
            if (left == 0)
                ret.Add(tmp.ToArray());
            for(var i = index; i < candidates.Length; ++ i) {
                if(i > index 
                && candidates[i] == candidates[i - 1]
                  )
                    continue;
                if (candidates[i] > left)
                    return;
                tmp.Add(candidates[i]);
                CombinationSum2(candidates, left - candidates[i], ret, tmp, i + 1);
                tmp.RemoveAt(tmp.Count - 1);
            }
        }
}
