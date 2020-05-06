using System;

namespace combination_sum_2
{
    class Program
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
            var ret = new List<IList<int>>(0);
            if (candidates)        
                return ret;
            Array.Sort(candidates);
            CombinationSum2(candidates, target, ret, new List<int>(), 0);
        }
        public void CombinationSum2(int[] candidates, int left, List<List<int>> ret, IList<int> tmp, int index) {
            if (left == 0)
                ret.Add(tmp.ToArray());
            for(var i = index; i < candidates.Length; ++ i) {
                
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
