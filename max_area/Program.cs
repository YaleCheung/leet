using System;

public class Program {
    public int MaxArea(int[] height) {
            var ret = 0;
            var start = 0;
            var end = height.Length - 1;

            while (start < end)
            {
                if (height[start] < height[end])
                {
                    ret = Math.Max(ret, height[start]*(end - start));
                    ++ start;
                }
                else
                {
                    ret = Math.Max(ret, height[end]*(end - start));
                    -- end;
                }
            }

            return ret;
    }
    public static void Main(string[] args) {
        var input = new int[args.Length];

        for(int order = 0; order < args.Length; ++ order) {
            input[order] = Convert.ToInt32(args[order], 10);
        }

        Console.WriteLine("{0}\n", new Program().MaxArea(input));
    }
}
