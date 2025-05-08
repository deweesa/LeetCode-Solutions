/* url: https://leetcode.com/problems/product-of-array-except-self/description/
 * description: Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
                The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
                You must write an algorithm that runs in O(n) time and without using the division operation.
 */
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var left_remainder = 1;
        var right_remainder = 1;

        var result = new int[nums.Length];
        Array.Fill(result, 1);

        for(int i = 0; i < nums.Length; i++) {
            result[i] = left_remainder;
            left_remainder *= nums[i];
        }

        for(int i = nums.Length-1; i >= 0; i--) {
            result[i] *= right_remainder;
            right_remainder *= nums[i];
        }

        return result;
    }
}
