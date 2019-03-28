using System;

namespace find_median_sorted_arrays
{
    public class Solution 
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int length1 = nums1.Length;
            int length2 = nums2.Length;
            int total = length1 + length2;
            if ((total & 0x1) != 0)  // odd
                return FindKthSmallestElement(nums1, 0, length1 - 1, nums2, 0, length2 - 1, (total + 1) / 2);
            else 
                return (FindKthSmallestElement(nums1, 0, length1 - 1, nums2, 0, length2 - 1, (total + 1) / 2) + 
                        FindKthSmallestElement(nums1, 0, length1 - 1, nums2, 0, length2 - 1, total / 2 + 1)) / 2.0 ;
        }
        public int FindKthSmallestElement(int[] nums1, int start1, int end1, int[] nums2, int start2, int end2, int k) {
            int length1 = end1 - start1 + 1;
            int length2 = end2 - start2 + 1;

            if (length1 > length2)
                return FindKthSmallestElement(nums2, start2, end2, nums1, start1, end1, k);
            if (0 == length1) 
                return nums2[start2 + k - 1];
            if (k == 1)
                return nums1[start1] > nums2[start2] ? nums2[start2] : nums1[start1];
            var half1 = k / 2 > length1 ? length1 : k / 2;
            var half2 = k / 2 > length2 ? length2 : k / 2;
            if (nums1[start1 + half1 - 1] > nums2[start2 + half2 - 1]) 
                return FindKthSmallestElement(nums1, start1, end1, nums2, start2 + half2, end2, k - half2);
            else 
                return FindKthSmallestElement(nums1, start1 + half1, end1, nums2, start2, end2, k - half1);
        }
        static void Main(string[] args)
        {
            int[] nums2 = new int[]{1,3,4};
            int[] nums1 = new int[]{2};
            Console.WriteLine("{0}\n", new Solution().FindMedianSortedArrays(nums1, nums2));

        }
    }
}
