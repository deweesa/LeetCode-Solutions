/* url: https://leetcode.com/problems/maximum-subarray/description/
 * description: Given an integer array nums, find the subarray with the largest sum, and return its sum.
 *              Example 1:
 *                Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
 *                Output: 6
 *                Explanation: The subarray [4,-1,2,1] has the largest sum 6.
 */
public class Solution {
    public int MaxSubArray(int[] nums) {
        int curr, max;
        curr = max = 0;

        foreach(int num in nums) {
            curr = Math.Max(num, curr + num);
            max = Math.Max(curr, max);
        }

        return max;
    }
}
