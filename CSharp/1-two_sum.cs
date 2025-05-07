/* url: https://leetcode.com/problems/two-sum/description/
 * description: Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
                You may assume that each input would have exactly one solution, and you may not use the same element twice.
                You can return the answer in any order.
 */
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var indexes = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];

            if(indexes.ContainsKey(diff)) {
                return [i, indexes[diff]];
            } else {
                if(!indexes.ContainsKey(nums[i])) {
                    indexes.Add(nums[i], i);
                }
            }
        }

        return [];
    }
}
