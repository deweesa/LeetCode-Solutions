/* https://leetcode.com/problems/find-the-difference-of-two-arrays/description/?envType=study-plan-v2&envId=leetcode-75
 *
 * Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:
 *
 * answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
 * answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
 *
 * Note that the integers in the lists may be returned in any order.
 */

public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> inNums1 = new HashSet<int>(nums1);
        HashSet<int> inNums2 = new HashSet<int>(nums2);

        List<int> notIn2 = new List<int>();
        List<int> notIn1 = new List<int>();

        foreach(int num in inNums1) {
            if(!inNums2.Contains(num)){
                notIn2.Add(num);
            }
        }

        foreach(int num in inNums2) {
            if(!inNums1.Contains(num)){
                notIn1.Add(num);
            }
        }

        List<List<int>> result = new List<List<int>>();

        result.Add(notIn2);
        result.Add(notIn1);

        return new List<IList<int>> {notIn2, notIn1};
    }
}


