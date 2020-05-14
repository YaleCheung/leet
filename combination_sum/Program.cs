using System;
using System.Collections.Generic;


namespace combination_sum
{
    class Program
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target) {
             var ret = new List<IList<int>>();
             CombinationSum(candidates, target, ret, new List<int>(), 0);
             return ret;
        }
        public void CombinationSum(int[] candidates, int target, List<IList<int>> ret, List<int> list_storage, int index) {
            if (target == 0) {
                ret.Add(list_storage.ToArray());
            }
            else if (target > 0){
                for (var i = index; i < candidates.Length; ++i)
                {
                    list_storage.Add(candidates[i]);
                    CombinationSum(candidates, target - candidates[i], ret, list_storage, i);
                    list_storage.RemoveAt(list_storage.Count - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = {
                    2, 3, 6, 7
            };
            var target = 7;

            var program = new Program();
            var ret = program.CombinationSum(array, target);
            Console.WriteLine("Hello World!");
        }
    }
}
