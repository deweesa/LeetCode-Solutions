/* url: https://leetcode.com/problems/contains-duplicate/description/
 * description: Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
 */
public class Solution {
    public bool slowContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();

        foreach(int i in nums) {
            if(set.Contains(i)) {
                return true;
            }

            set.Add(i);
        }

        return false;
    }

    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>(nums);

        return set.Count != nums.Length;
    }
}
